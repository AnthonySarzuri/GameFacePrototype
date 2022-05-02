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
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(11, 13);
            this.PBProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Size = new System.Drawing.Size(146, 141);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 6;
            this.PBProfilePicture.TabStop = false;
            // 
            // LBLShowUser
            // 
            this.LBLShowUser.AutoSize = true;
            this.LBLShowUser.Location = new System.Drawing.Point(215, 12);
            this.LBLShowUser.Name = "LBLShowUser";
            this.LBLShowUser.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUser.TabIndex = 7;
            this.LBLShowUser.Text = "label1";
            // 
            // LBLShowUserId
            // 
            this.LBLShowUserId.AutoSize = true;
            this.LBLShowUserId.Location = new System.Drawing.Point(215, 37);
            this.LBLShowUserId.Name = "LBLShowUserId";
            this.LBLShowUserId.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUserId.TabIndex = 8;
            this.LBLShowUserId.Text = "label2";
            // 
            // LBLShowBirthday
            // 
            this.LBLShowBirthday.AutoSize = true;
            this.LBLShowBirthday.Location = new System.Drawing.Point(215, 63);
            this.LBLShowBirthday.Name = "LBLShowBirthday";
            this.LBLShowBirthday.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBirthday.TabIndex = 9;
            this.LBLShowBirthday.Text = "label3";
            // 
            // BTNAddFriend
            // 
            this.BTNAddFriend.Location = new System.Drawing.Point(27, 159);
            this.BTNAddFriend.Name = "BTNAddFriend";
            this.BTNAddFriend.Size = new System.Drawing.Size(28, 23);
            this.BTNAddFriend.TabIndex = 11;
            this.BTNAddFriend.Text = "+";
            this.BTNAddFriend.UseVisualStyleBackColor = true;
            this.BTNAddFriend.Click += new System.EventHandler(this.BTNAddFriend_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(867, 7);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(31, 23);
            this.BTNBack.TabIndex = 13;
            this.BTNBack.Text = "X";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // LBLShowBiography
            // 
            this.LBLShowBiography.AutoSize = true;
            this.LBLShowBiography.Location = new System.Drawing.Point(215, 87);
            this.LBLShowBiography.Name = "LBLShowBiography";
            this.LBLShowBiography.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBiography.TabIndex = 14;
            this.LBLShowBiography.Text = "label1";
            // 
            // panel1
            // 
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 240);
            this.panel1.TabIndex = 15;
            // 
            // LBLLastTime
            // 
            this.LBLLastTime.AutoSize = true;
            this.LBLLastTime.Location = new System.Drawing.Point(27, 210);
            this.LBLLastTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLLastTime.Name = "LBLLastTime";
            this.LBLLastTime.Size = new System.Drawing.Size(35, 13);
            this.LBLLastTime.TabIndex = 16;
            this.LBLLastTime.Text = "label5";
            // 
            // LBLLastDay
            // 
            this.LBLLastDay.AutoSize = true;
            this.LBLLastDay.Location = new System.Drawing.Point(27, 188);
            this.LBLLastDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLLastDay.Name = "LBLLastDay";
            this.LBLLastDay.Size = new System.Drawing.Size(35, 13);
            this.LBLLastDay.TabIndex = 15;
            this.LBLLastDay.Text = "label4";
            // 
            // PanelPosts
            // 
            this.PanelPosts.AutoScroll = true;
            this.PanelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPosts.Location = new System.Drawing.Point(0, 240);
            this.PanelPosts.Name = "PanelPosts";
            this.PanelPosts.Size = new System.Drawing.Size(910, 821);
            this.PanelPosts.TabIndex = 16;
            // 
            // ProfileThird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 1061);
            this.Controls.Add(this.PanelPosts);
            this.Controls.Add(this.panel1);
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
    }
}