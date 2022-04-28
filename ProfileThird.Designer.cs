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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAddFriend = new System.Windows.Forms.Button();
            this.BTNShowFriends = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.LBLShowBiography = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(11, 37);
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
            this.LBLShowUser.Location = new System.Drawing.Point(189, 37);
            this.LBLShowUser.Name = "LBLShowUser";
            this.LBLShowUser.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUser.TabIndex = 7;
            this.LBLShowUser.Text = "label1";
            // 
            // LBLShowUserId
            // 
            this.LBLShowUserId.AutoSize = true;
            this.LBLShowUserId.Location = new System.Drawing.Point(189, 62);
            this.LBLShowUserId.Name = "LBLShowUserId";
            this.LBLShowUserId.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUserId.TabIndex = 8;
            this.LBLShowUserId.Text = "label2";
            // 
            // LBLShowBirthday
            // 
            this.LBLShowBirthday.AutoSize = true;
            this.LBLShowBirthday.Location = new System.Drawing.Point(189, 88);
            this.LBLShowBirthday.Name = "LBLShowBirthday";
            this.LBLShowBirthday.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBirthday.TabIndex = 9;
            this.LBLShowBirthday.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 191);
            this.panel1.TabIndex = 10;
            // 
            // BTNAddFriend
            // 
            this.BTNAddFriend.Location = new System.Drawing.Point(27, 183);
            this.BTNAddFriend.Name = "BTNAddFriend";
            this.BTNAddFriend.Size = new System.Drawing.Size(28, 23);
            this.BTNAddFriend.TabIndex = 11;
            this.BTNAddFriend.Text = "+";
            this.BTNAddFriend.UseVisualStyleBackColor = true;
            // 
            // BTNShowFriends
            // 
            this.BTNShowFriends.Location = new System.Drawing.Point(71, 183);
            this.BTNShowFriends.Name = "BTNShowFriends";
            this.BTNShowFriends.Size = new System.Drawing.Size(75, 23);
            this.BTNShowFriends.TabIndex = 12;
            this.BTNShowFriends.Text = "Amigos";
            this.BTNShowFriends.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(564, 6);
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
            this.LBLShowBiography.Location = new System.Drawing.Point(189, 112);
            this.LBLShowBiography.Name = "LBLShowBiography";
            this.LBLShowBiography.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBiography.TabIndex = 14;
            this.LBLShowBiography.Text = "label1";
            // 
            // ProfileThird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.LBLShowBiography);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNShowFriends);
            this.Controls.Add(this.BTNAddFriend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBLShowBirthday);
            this.Controls.Add(this.LBLShowUserId);
            this.Controls.Add(this.LBLShowUser);
            this.Controls.Add(this.PBProfilePicture);
            this.Name = "ProfileThird";
            this.Text = "ProfileThird";
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Label LBLShowUser;
        private System.Windows.Forms.Label LBLShowUserId;
        private System.Windows.Forms.Label LBLShowBirthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNAddFriend;
        private System.Windows.Forms.Button BTNShowFriends;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Label LBLShowBiography;
    }
}