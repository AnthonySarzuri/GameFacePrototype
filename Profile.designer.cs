namespace GameFacePrototype
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.btnNewPost = new System.Windows.Forms.Button();
            this.btnEditProfilePicture = new System.Windows.Forms.Button();
            this.btnComentarioPrueba = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.LBLShowBirthday = new System.Windows.Forms.Label();
            this.LBLShowUserId = new System.Windows.Forms.Label();
            this.LBLShowBiography = new System.Windows.Forms.Label();
            this.LBLShowUser = new System.Windows.Forms.Label();
            this.BTNShowFriends = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnRefreshNewPosts = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPost
            // 
            this.btnNewPost.Location = new System.Drawing.Point(802, 16);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(153, 26);
            this.btnNewPost.TabIndex = 25;
            this.btnNewPost.Text = "Nueva Publicacion +";
            this.btnNewPost.UseVisualStyleBackColor = true;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            // 
            // btnEditProfilePicture
            // 
            this.btnEditProfilePicture.Location = new System.Drawing.Point(802, 90);
            this.btnEditProfilePicture.Name = "btnEditProfilePicture";
            this.btnEditProfilePicture.Size = new System.Drawing.Size(153, 27);
            this.btnEditProfilePicture.TabIndex = 24;
            this.btnEditProfilePicture.Text = "Editar perfil";
            this.btnEditProfilePicture.UseVisualStyleBackColor = true;
            this.btnEditProfilePicture.Click += new System.EventHandler(this.btnEditProfilePicture_Click);
            // 
            // btnComentarioPrueba
            // 
            this.btnComentarioPrueba.Location = new System.Drawing.Point(802, 54);
            this.btnComentarioPrueba.Name = "btnComentarioPrueba";
            this.btnComentarioPrueba.Size = new System.Drawing.Size(153, 21);
            this.btnComentarioPrueba.TabIndex = 22;
            this.btnComentarioPrueba.Text = "Comentario Prueba";
            this.btnComentarioPrueba.UseVisualStyleBackColor = true;
            this.btnComentarioPrueba.Click += new System.EventHandler(this.btnComentarioPrueba_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnRefreshNewPosts);
            this.panelLeft.Controls.Add(this.PBProfilePicture);
            this.panelLeft.Controls.Add(this.LBLShowBirthday);
            this.panelLeft.Controls.Add(this.LBLShowUserId);
            this.panelLeft.Controls.Add(this.LBLShowBiography);
            this.panelLeft.Controls.Add(this.LBLShowUser);
            this.panelLeft.Controls.Add(this.BTNShowFriends);
            this.panelLeft.Controls.Add(this.btnEditProfilePicture);
            this.panelLeft.Controls.Add(this.btnNewPost);
            this.panelLeft.Controls.Add(this.btnComentarioPrueba);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1011, 301);
            this.panelLeft.TabIndex = 22;
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(30, 30);
            this.PBProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Size = new System.Drawing.Size(146, 141);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 33;
            this.PBProfilePicture.TabStop = false;
            // 
            // LBLShowBirthday
            // 
            this.LBLShowBirthday.AutoSize = true;
            this.LBLShowBirthday.Location = new System.Drawing.Point(234, 80);
            this.LBLShowBirthday.Name = "LBLShowBirthday";
            this.LBLShowBirthday.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBirthday.TabIndex = 36;
            this.LBLShowBirthday.Text = "label3";
            // 
            // LBLShowUserId
            // 
            this.LBLShowUserId.AutoSize = true;
            this.LBLShowUserId.Location = new System.Drawing.Point(234, 54);
            this.LBLShowUserId.Name = "LBLShowUserId";
            this.LBLShowUserId.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUserId.TabIndex = 35;
            this.LBLShowUserId.Text = "label2";
            // 
            // LBLShowBiography
            // 
            this.LBLShowBiography.AutoSize = true;
            this.LBLShowBiography.Location = new System.Drawing.Point(234, 104);
            this.LBLShowBiography.Name = "LBLShowBiography";
            this.LBLShowBiography.Size = new System.Drawing.Size(35, 13);
            this.LBLShowBiography.TabIndex = 38;
            this.LBLShowBiography.Text = "label1";
            // 
            // LBLShowUser
            // 
            this.LBLShowUser.AutoSize = true;
            this.LBLShowUser.Location = new System.Drawing.Point(234, 29);
            this.LBLShowUser.Name = "LBLShowUser";
            this.LBLShowUser.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUser.TabIndex = 34;
            this.LBLShowUser.Text = "label1";
            // 
            // BTNShowFriends
            // 
            this.BTNShowFriends.Location = new System.Drawing.Point(90, 176);
            this.BTNShowFriends.Name = "BTNShowFriends";
            this.BTNShowFriends.Size = new System.Drawing.Size(75, 23);
            this.BTNShowFriends.TabIndex = 37;
            this.BTNShowFriends.Text = "Amigos";
            this.BTNShowFriends.UseVisualStyleBackColor = true;
            this.BTNShowFriends.Click += new System.EventHandler(this.BTNShowFriends_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 301);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1011, 448);
            this.PanelPrincipal.TabIndex = 26;
            // 
            // btnRefreshNewPosts
            // 
            this.btnRefreshNewPosts.Location = new System.Drawing.Point(802, 132);
            this.btnRefreshNewPosts.Name = "btnRefreshNewPosts";
            this.btnRefreshNewPosts.Size = new System.Drawing.Size(153, 24);
            this.btnRefreshNewPosts.TabIndex = 39;
            this.btnRefreshNewPosts.Text = "Cargar mas posts";
            this.btnRefreshNewPosts.UseVisualStyleBackColor = true;
            this.btnRefreshNewPosts.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 749);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panelLeft);
            this.Name = "Profile";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComentarioPrueba;
        private System.Windows.Forms.Button btnEditProfilePicture;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Label LBLShowBirthday;
        private System.Windows.Forms.Label LBLShowUserId;
        private System.Windows.Forms.Label LBLShowBiography;
        private System.Windows.Forms.Label LBLShowUser;
        private System.Windows.Forms.Button BTNShowFriends;
        private System.Windows.Forms.Button btnRefreshNewPosts;
    }
}