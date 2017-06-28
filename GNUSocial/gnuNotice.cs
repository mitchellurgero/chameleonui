using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GNUSocial
{
    public partial class gnuNotice : UserControl
    {
        public string notice_id;
        public string notice_text;
        public string profile_pic;
        public string notice_user;
        public string notice_name;
        public string notice_date;
        public string in_reply_to_status_id;
        public string user;
        public string pass;
        public string server;
        public gnuNotice()
        {
            InitializeComponent();
            profilePic.ImageLocation = profile_pic;
            noticeText.Text = notice_text;
            username.Text = notice_user;
            date.Text = notice_date;

        }
        public void log(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
        private void gnuNotice_Load(object sender, EventArgs e)
        {
            profilePic.ImageLocation = profile_pic;
            noticeText.Text = notice_text;
            username.Text = notice_user;
            date.Text = notice_date;
        }

        private void reply_Click(object sender, EventArgs e)
        {
            newNotice nn = new newNotice();
            nn.reply_id = notice_id;
            nn.reply_to = notice_name;
            nn.Text = "Replying to: " + "("+notice_id+")";
            nn.ShowDialog();
            nn.Dispose();
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            try
            {
                user = Properties.Settings.Default.username;
                pass = Properties.Settings.Default.password;
                server = Properties.Settings.Default.server;
                //Now to login...
                string URI = server + "/api/statuses/retweet/" + notice_id + ".json";
                string myParameters = "username=" + user + "&password=" + pass + "&id=" + notice_id;
                //Continue to login..
                log("Reposting " + notice_id);
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    string HtmlResult = wc.UploadString(URI, myParameters);
                    log("Completed reposting " + notice_id);
                }
            }
            catch(Exception ex)
            {
                log("!!ERROR!!: " + ex.Message); 
            }
        }

        private void favorite_Click(object sender, EventArgs e)
        {
            try
            {
                user = Properties.Settings.Default.username;
                pass = Properties.Settings.Default.password;
                server = Properties.Settings.Default.server;
                //Now to login...
                string URI = server + "/api/favorites/create/" + notice_id + ".json";
                string myParameters = "username=" + user + "&password=" + pass + "&id=" + notice_id;
                //Continue to login..
                log("Favoriting " + notice_id);
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    string HtmlResult = wc.UploadString(URI, myParameters);
                    log("Completed favoriting " + notice_id);
                }
            }
            catch (Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
        }
    }
}
