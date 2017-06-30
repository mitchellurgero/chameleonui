using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;

namespace GNUSocial
{
    public partial class MainFrm : MetroForm
    {
        public string server;
        public string user;
        public string pass;
        public bool isRefreshingHome = false;
        public bool isRefreshingPublic = false;
        public string version = "ChameleonUI - GS Windows API App v0.1a";
        public MainFrm()
        {
            InitializeComponent();
        }
        public void log(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = version;
            login();
            
        }
        public void login()
        {
            try
            {
                if (isRefreshingHome && isRefreshingPublic)
                {
                    return;
                }
                if (!String.IsNullOrEmpty(Properties.Settings.Default.username) || !String.IsNullOrEmpty(Properties.Settings.Default.password))
                {
                    user = Properties.Settings.Default.username;
                    pass = Properties.Settings.Default.password;
                    server = Properties.Settings.Default.server;
                    //Now to login...
                    string URI = server + "/api/qvitter/checklogin.json";
                    string myParameters = "username=" + user + "&password=" + pass;
                    //Continue to login..
                    log("Logging into " + server);
                    using (WebClient wc = new WebClient())
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        string HtmlResult = wc.UploadString(URI, myParameters);
                        log("Login successful!");
                        var serializer = new JavaScriptSerializer();
                        serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
                        dynamic obj = serializer.Deserialize(HtmlResult, typeof(object));
                        log("Setting user info now...");
                        userAvatar.ImageLocation = obj.profile_image_url;
                        userName.Text = obj.name;
                        idName.Text = obj.screen_name;
                        noticeCount.Text = obj.statuses_count.ToString();
                        followCount.Text = obj.friends_count.ToString();
                        readHomeTimeline();
                        //readNotifications();
                        readPublicTimeline();
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    //Login not exist. Prompt for login.
                    LoginFrm lf = new LoginFrm();
                    lf.ShowDialog();
                    lf.Dispose();
                }
            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
                if(ex.Message.Contains("401") || ex.Message.Contains("404") || ex.Message.Contains("500") || ex.Message.Contains("503"))
                {
                    MessageBox.Show("There was an error logging into your account on '" + server + "'. Please logout, and log back in." + Environment.NewLine + "(There are more details in console log...)");
                }
            }
        }
        public void readHomeTimeline()
        {
            try
            {
                isRefreshingHome = true;
                Uri URI = new Uri(server + "/api/statuses/friends_timeline.json");
                //string myParameters = "username=" + user + "&password=" + pass;
                //Continue to login..
                log("Requesting home timeline...");
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    wc.DownloadStringAsync(URI);
                    wc.DownloadStringCompleted += homeTimeline_DownloadStringCompleted;
                }
            }
            catch(Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }         

        }
        void homeTimeline_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                homePanel.Controls.Clear();
                log("Successfully downloaded home timeline..");
                //Do something with the data here eventually...
                var serializer = new JavaScriptSerializer();
                serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
                dynamic obj = serializer.Deserialize(e.Result, typeof(object));
                log(obj.Length.ToString() + " notices received.");
                Array.Reverse(obj);
                for (int i = 1; i < obj.Length; i++)
                {
                    //Let's just process one for now, see how it looks.
                    gnuNotice gn = new gnuNotice();
                    gn.notice_id = obj[i].id.ToString();
                    gn.notice_text = obj[i].text;//obj[i].statusnet_html;
                    gn.notice_date = obj[i].created_at;
                    gn.notice_user = obj[i].user.name;
                    gn.notice_name = obj[i].user.screen_name;
                    gn.profile_pic = obj[i].user.profile_image_url;
                    //Keep statusnet conversation active, and tag everyone that needs to be tagged.
                    if (!string.IsNullOrEmpty(obj[i].statusnet_conversation_id.ToString()))
                    {
                        gn.statusnet_conversation_id = obj[i].statusnet_conversation_id.ToString();
                    }
                    if (obj[i].attentions != null && obj[i].attentions.Count > 0)
                    {
                        
                        gn.attentions = obj[i].attentions;
                    }
                    gn.Dock = DockStyle.Top;
                    homePanel.Controls.Add(gn);
                    //break;
                }
                
            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
            isRefreshingHome = false;
        }
        void publicTimeline_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                publicPanel.Controls.Clear();
                log("Successfully downloaded public timeline..");
                //Do something with the data here eventually...
                var serializer = new JavaScriptSerializer();
                serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
                dynamic obj = serializer.Deserialize(e.Result, typeof(object));
                log(obj.Length.ToString() + " notices received.");
                Array.Reverse(obj);
                for (int i = 1; i < obj.Length; i++)
                {
                    //Let's just process one for now, see how it looks.
                    gnuNotice gn = new gnuNotice();
                    gn.notice_id = obj[i].id.ToString();
                    gn.notice_text = obj[i].text;//obj[i].statusnet_html;
                    gn.notice_date = obj[i].created_at;
                    gn.notice_user = obj[i].user.name;
                    gn.notice_name = obj[i].user.screen_name;
                    gn.profile_pic = obj[i].user.profile_image_url;
                    //Keep statusnet conversation active, and tag everyone that needs to be tagged.
                    if (!string.IsNullOrEmpty(obj[i].statusnet_conversation_id.ToString()))
                    {
                        gn.statusnet_conversation_id = obj[i].statusnet_conversation_id.ToString();
                    }
                    if (obj[i].attentions != null && obj[i].attentions.Count > 0)
                    {

                        gn.attentions = obj[i].attentions;
                    }
                    gn.Dock = DockStyle.Top;
                    publicPanel.Controls.Add(gn);
                    //break;
                }

            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
            isRefreshingPublic = false;
        }
        public void readNotifications()
        {
            try
            {
                string URI = server + "/api/qvitter/statuses/notifications.json";
                //string myParameters = "username=" + user + "&password=" + pass;
                //Continue to login..
                log("Requesting notifications timeline...");
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    string HtmlResult = wc.DownloadString(URI);
                    log("Successfully downloaded notifications timeline..");
                    //Do something with the data here eventually...
                }
            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
        }
        public void readPublicTimeline()
        {
            try
            {
                isRefreshingPublic = true;
                Uri URI = new Uri(server + "/api/statuses/public_and_external_timeline.json");
                //string myParameters = "username=" + user + "&password=" + pass;
                //Continue to login..
                log("Requesting public timeline...");
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    wc.DownloadStringAsync(URI);
                    wc.DownloadStringCompleted += publicTimeline_DownloadStringCompleted;
                }
            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Try to login every 15 seconds so we have most up-to-date information about the user.
            login();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            log("Resetting app...");
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            log("Open newNotice form...");
            newNotice nn = new newNotice();
            nn.ShowDialog();
            nn.Dispose();
            //login();
        }
    }
}
