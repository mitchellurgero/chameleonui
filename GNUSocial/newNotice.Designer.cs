namespace GNUSocial
{
    partial class newNotice
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
            this.postContent = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.charCount = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // postContent
            // 
            this.postContent.Location = new System.Drawing.Point(23, 63);
            this.postContent.Multiline = true;
            this.postContent.Name = "postContent";
            this.postContent.Size = new System.Drawing.Size(345, 115);
            this.postContent.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(280, 184);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 40);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Post!";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(23, 184);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(104, 19);
            this.charCount.TabIndex = 2;
            this.charCount.Text = "{CHAR_COUNT}";
            // 
            // newNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.postContent);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(397, 245);
            this.Name = "newNotice";
            this.Text = "New Notice";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.newNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox postContent;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel charCount;
    }
}