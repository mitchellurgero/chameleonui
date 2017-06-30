using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNUSocial
{
    public partial class newNotice : MetroForm
    {
        public string user;
        public string pass;
        public string server;
        public string reply_id;
        public string reply_to;
        public string statusnet_conversation_id;
        public List<dynamic> attentions;
        public newNotice()
        {
            InitializeComponent();
        }

        private void newNotice_Load(object sender, EventArgs e)
        {
            try
            {
                if(attentions != null)
                {
                    for (int i = 0; i < attentions.Count; i++)
                    {
                        if(i == 0 && reply_to != Properties.Settings.Default.username)
                        {
                            postContent.Text = "@" + reply_to + " ";
                        }
                        if(attentions[i].screen_name == Properties.Settings.Default.username)
                        {
                            continue;
                        }
                        postContent.Text += "@" + attentions[i].screen_name + " ";
                    }
                } else if(!string.IsNullOrEmpty(reply_to))
                {
                    postContent.Text = "@" + reply_to + " ";
                } else
                {

                }
                
            }catch(Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
            }
        }
        public void log(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(reply_id))
                {
                    reply_id = "&in_reply_to_status_id=" + reply_id;
                }
                if (!string.IsNullOrEmpty(statusnet_conversation_id))
                {
                    statusnet_conversation_id = "&statusnet_conversation_id=" + statusnet_conversation_id;
                }
                user = Properties.Settings.Default.username;
                pass = Properties.Settings.Default.password;
                server = Properties.Settings.Default.server;
                //Now to login...
                string URI = server + "/api/statuses/update.json";
                string myParameters = "status=" + postContent.Text + "&source=ChameleonUI" + reply_id + statusnet_conversation_id;
                //Continue to login..
                log("Updating status to " + postContent.Text);
                this.Enabled = false;
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    wc.Credentials = new NetworkCredential(user, pass);
                    string HtmlResult = wc.UploadString(URI, myParameters);
                }
                //Finished, lets close. 
                log("Status updated successfully!");
                this.Close();
            }
            catch(Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
                MessageBox.Show(ex.Message, "Cannot send notice!");
            }
        }
    }
}
