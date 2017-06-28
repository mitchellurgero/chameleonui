namespace GNUSocial
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.homePanel = new System.Windows.Forms.Panel();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noticeCount = new System.Windows.Forms.Label();
            this.followCount = new System.Windows.Forms.Label();
            this.idName = new System.Windows.Forms.Label();
            this.publicPanel = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(431, 374);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.homePanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(423, 335);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.publicPanel);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(423, 335);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Public";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // homePanel
            // 
            this.homePanel.AutoScroll = true;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(423, 335);
            this.homePanel.TabIndex = 2;
            // 
            // userAvatar
            // 
            this.userAvatar.Location = new System.Drawing.Point(24, 16);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(38, 38);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 1;
            this.userAvatar.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(66, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(76, 13);
            this.userName.TabIndex = 2;
            this.userName.Text = "{USERNAME}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Following:";
            // 
            // noticeCount
            // 
            this.noticeCount.AutoSize = true;
            this.noticeCount.Location = new System.Drawing.Point(238, 33);
            this.noticeCount.Name = "noticeCount";
            this.noticeCount.Size = new System.Drawing.Size(59, 13);
            this.noticeCount.TabIndex = 5;
            this.noticeCount.Text = "{nCOUNT}";
            // 
            // followCount
            // 
            this.followCount.AutoSize = true;
            this.followCount.Location = new System.Drawing.Point(325, 33);
            this.followCount.Name = "followCount";
            this.followCount.Size = new System.Drawing.Size(56, 13);
            this.followCount.TabIndex = 6;
            this.followCount.Text = "{fCOUNT}";
            // 
            // idName
            // 
            this.idName.AutoSize = true;
            this.idName.Location = new System.Drawing.Point(66, 37);
            this.idName.Name = "idName";
            this.idName.Size = new System.Drawing.Size(76, 13);
            this.idName.TabIndex = 7;
            this.idName.Text = "{USERNAME}";
            // 
            // publicPanel
            // 
            this.publicPanel.AutoScroll = true;
            this.publicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publicPanel.Location = new System.Drawing.Point(0, 0);
            this.publicPanel.Name = "publicPanel";
            this.publicPanel.Size = new System.Drawing.Size(423, 335);
            this.publicPanel.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(242, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Post";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(305, 63);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(55, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Logout";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 454);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.idName);
            this.Controls.Add(this.followCount);
            this.Controls.Add(this.noticeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(471, 454);
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noticeCount;
        private System.Windows.Forms.Label followCount;
        private System.Windows.Forms.Label idName;
        private System.Windows.Forms.Panel publicPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}