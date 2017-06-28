namespace GNUSocial
{
    partial class gnuNotice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.noticeText = new System.Windows.Forms.RichTextBox();
            this.reply = new System.Windows.Forms.PictureBox();
            this.repeat = new System.Windows.Forms.PictureBox();
            this.favorite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favorite)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(3, 3);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(36, 36);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username.Location = new System.Drawing.Point(45, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(76, 13);
            this.username.TabIndex = 1;
            this.username.Text = "{USERNAME}";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(45, 24);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 13);
            this.date.TabIndex = 2;
            this.date.Text = "{DATE}";
            // 
            // noticeText
            // 
            this.noticeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noticeText.Location = new System.Drawing.Point(3, 40);
            this.noticeText.Name = "noticeText";
            this.noticeText.ReadOnly = true;
            this.noticeText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.noticeText.Size = new System.Drawing.Size(277, 110);
            this.noticeText.TabIndex = 3;
            this.noticeText.Text = "";
            // 
            // reply
            // 
            this.reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reply.Image = global::GNUSocial.Properties.Resources.next;
            this.reply.Location = new System.Drawing.Point(3, 153);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(23, 23);
            this.reply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reply.TabIndex = 4;
            this.reply.TabStop = false;
            this.reply.Click += new System.EventHandler(this.reply_Click);
            // 
            // repeat
            // 
            this.repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat.Image = global::GNUSocial.Properties.Resources.reload;
            this.repeat.Location = new System.Drawing.Point(36, 153);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(23, 23);
            this.repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repeat.TabIndex = 5;
            this.repeat.TabStop = false;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // favorite
            // 
            this.favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favorite.Image = global::GNUSocial.Properties.Resources.like;
            this.favorite.Location = new System.Drawing.Point(67, 153);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(23, 23);
            this.favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favorite.TabIndex = 6;
            this.favorite.TabStop = false;
            this.favorite.Click += new System.EventHandler(this.favorite_Click);
            // 
            // gnuNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.favorite);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.noticeText);
            this.Controls.Add(this.date);
            this.Controls.Add(this.username);
            this.Controls.Add(this.profilePic);
            this.Name = "gnuNotice";
            this.Size = new System.Drawing.Size(283, 179);
            this.Load += new System.EventHandler(this.gnuNotice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RichTextBox noticeText;
        private System.Windows.Forms.PictureBox reply;
        private System.Windows.Forms.PictureBox repeat;
        private System.Windows.Forms.PictureBox favorite;
    }
}
