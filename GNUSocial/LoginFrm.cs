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
namespace GNUSocial
{
    public partial class LoginFrm : MetroForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }
        public void log(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string user = metroTextBox1.Text;
            string pass = metroTextBox2.Text;
            string server = metroTextBox3.Text;
            //Now to login...
            string URI = server + "/api/qvitter/checklogin.json";
            string myParameters = "username="+user+"&password="+pass;
            try
            {
                log("Logging into " + server);
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(URI, myParameters);
                    log("Login successful!");
                    log("Saving login data...");
                    Properties.Settings.Default.username = user;
                    Properties.Settings.Default.password = pass;
                    Properties.Settings.Default.server = server;
                    Properties.Settings.Default.Save();
                    log("Saved login data! Please restart the application!");
                    MessageBox.Show("Please Restart the application.", "Loggin Successful!", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                log("!!ERROR!!: " + ex.Message);
                MessageBox.Show(ex.Message, "Login error:", MessageBoxButtons.OK);
                metroTextBox2.Text = "";
            }
            
        }
    }
}
