namespace GameFacePrototype
{
    partial class ProfileThird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileThird));
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.LBLShowUser = new System.Windows.Forms.Label();
            this.LBLShowUserId = new System.Windows.Forms.Label();
            this.LBLShowBirthday = new System.Windows.Forms.Label();
            this.BTNAddFriend = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.LBLShowBiography = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLLastTime = new System.Windows.Forms.Label();
            this.LBLLastDay = new System.Windows.Forms.Label();
            this.PanelPosts = new System.Windows.Forms.Panel();
            this.tmconected = new System.Windows.Forms.Timer(this.components);
            this.lblConection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(15, 16);
            this.PBProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Size = new System.Drawing.Size(195, 174);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 6;
            this.PBProfilePicture.TabStop = false;
            // 
            // LBLShowUser
            // 
            this.LBLShowUser.AutoSize = true;
            this.LBLShowUser.Location = new System.Drawing.Point(287, 15);
            this.LBLShowUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLShowUser.Name = "LBLShowUser";
            this.LBLShowUser.Size = new System.Drawing.Size(46, 17);
            this.LBLShowUser.TabIndex = 7;
            this.LBLShowUser.Text = "label1";
            // 
            // LBLShowUserId
            // 
            this.LBLShowUserId.AutoSize = true;
            this.LBLShowUserId.Location = new System.Drawing.Point(287, 46);
            this.LBLShowUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLShowUserId.Name = "LBLShowUserId";
            this.LBLShowUserId.Size = new System.Drawing.Size(46, 17);
            this.LBLShowUserId.TabIndex = 8;
            this.LBLShowUserId.Text = "label2";
            // 
            // LBLShowBirthday
            // 
            this.LBLShowBirthday.AutoSize = true;
            this.LBLShowBirthday.Location = new System.Drawing.Point(287, 78);
            this.LBLShowBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLShowBirthday.Name = "LBLShowBirthday";
            this.LBLShowBirthday.Size = new System.Drawing.Size(46, 17);
            this.LBLShowBirthday.TabIndex = 9;
            this.LBLShowBirthday.Text = "label3";
            // 
            // BTNAddFriend
            // 
            this.BTNAddFriend.Location = new System.Drawing.Point(36, 196);
            this.BTNAddFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAddFriend.Name = "BTNAddFriend";
            this.BTNAddFriend.Size = new System.Drawing.Size(37, 28);
            this.BTNAddFriend.TabIndex = 11;
            this.BTNAddFriend.Text = "+";
            this.BTNAddFriend.UseVisualStyleBackColor = true;
            this.BTNAddFriend.Click += new System.EventHandler(this.BTNAddFriend_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(1156, 9);
            this.BTNBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(41, 28);
            this.BTNBack.TabIndex = 13;
            this.BTNBack.Text = "X";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // LBLShowBiography
            // 
            this.LBLShowBiography.AutoSize = true;
            this.LBLShowBiography.Location = new System.Drawing.Point(287, 107);
            this.LBLShowBiography.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLShowBiography.Name = "LBLShowBiography";
            this.LBLShowBiography.Size = new System.Drawing.Size(46, 17);
            this.LBLShowBiography.TabIndex = 14;
            this.LBLShowBiography.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConection);
            this.panel1.Controls.Add(this.LBLLastTime);
            this.panel1.Controls.Add(this.LBLLastDay);
            this.panel1.Controls.Add(this.PBProfilePicture);
            this.panel1.Controls.Add(this.BTNBack);
            this.panel1.Controls.Add(this.LBLShowBiography);
            this.panel1.Controls.Add(this.LBLShowUser);
            this.panel1.Controls.Add(this.LBLShowUserId);
            this.panel1.Controls.Add(this.LBLShowBirthday);
            this.panel1.Controls.Add(this.BTNAddFriend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 325);
            this.panel1.TabIndex = 15;
            // 
            // LBLLastTime
            // 
            this.LBLLastTime.AutoSize = true;
            this.LBLLastTime.Location = new System.Drawing.Point(36, 258);
            this.LBLLastTime.Name = "LBLLastTime";
            this.LBLLastTime.Size = new System.Drawing.Size(46, 17);
            this.LBLLastTime.TabIndex = 16;
            this.LBLLastTime.Text = "label5";
            // 
            // LBLLastDay
            // 
            this.LBLLastDay.AutoSize = true;
            this.LBLLastDay.Location = new System.Drawing.Point(36, 231);
            this.LBLLastDay.Name = "LBLLastDay";
            this.LBLLastDay.Size = new System.Drawing.Size(46, 17);
            this.LBLLastDay.TabIndex = 15;
            this.LBLLastDay.Text = "label4";
            // 
            // PanelPosts
            // 
            this.PanelPosts.AutoScroll = true;
            this.PanelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPosts.Location = new System.Drawing.Point(0, 325);
            this.PanelPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelPosts.Name = "PanelPosts";
            this.PanelPosts.Size = new System.Drawing.Size(1213, 730);
            this.PanelPosts.TabIndex = 16;
            // 
            // tmconected
            // 
            this.tmconected.Enabled = true;
            this.tmconected.Interval = 90000;
            this.tmconected.Tick += new System.EventHandler(this.tmconected_Tick);
            // 
            // lblConection
            // 
            this.lblConection.AutoSize = true;
            this.lblConection.Location = new System.Drawing.Point(36, 288);
            this.lblConection.Name = "lblConection";
            this.lblConection.Size = new System.Drawing.Size(46, 17);
            this.lblConection.TabIndex = 17;
            this.lblConection.Text = "label6";
            // 
            // ProfileThird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 1055);
            this.Controls.Add(this.PanelPosts);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfileThird";
            this.Text = "ProfileThird";
            this.Load += new System.EventHandler(this.ProfileThird_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Label LBLShowUser;
        private System.Windows.Forms.Label LBLShowUserId;
        private System.Windows.Forms.Label LBLShowBirthday;
        private System.Windows.Forms.Button BTNAddFriend;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Label LBLShowBiography;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelPosts;
        private System.Windows.Forms.Label LBLLastDay;
        private System.Windows.Forms.Label LBLLastTime;
        private System.Windows.Forms.Timer tmconected;
        private System.Windows.Forms.Label lblConection;
    }
}