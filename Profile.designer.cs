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
            this.btnNewPost = new System.Windows.Forms.Button();
            this.btnEditProfilePicture = new System.Windows.Forms.Button();
            this.btnComentarioPrueba = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewPost
            // 
            this.btnNewPost.Location = new System.Drawing.Point(33, 59);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(153, 76);
            this.btnNewPost.TabIndex = 25;
            this.btnNewPost.Text = "Nueva Publicacion +";
            this.btnNewPost.UseVisualStyleBackColor = true;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            // 
            // btnEditProfilePicture
            // 
            this.btnEditProfilePicture.Location = new System.Drawing.Point(26, 59);
            this.btnEditProfilePicture.Name = "btnEditProfilePicture";
            this.btnEditProfilePicture.Size = new System.Drawing.Size(153, 72);
            this.btnEditProfilePicture.TabIndex = 24;
            this.btnEditProfilePicture.Text = "Editar perfil";
            this.btnEditProfilePicture.UseVisualStyleBackColor = true;
            this.btnEditProfilePicture.Click += new System.EventHandler(this.btnEditProfilePicture_Click);
            // 
            // btnComentarioPrueba
            // 
            this.btnComentarioPrueba.Location = new System.Drawing.Point(33, 218);
            this.btnComentarioPrueba.Name = "btnComentarioPrueba";
            this.btnComentarioPrueba.Size = new System.Drawing.Size(153, 59);
            this.btnComentarioPrueba.TabIndex = 22;
            this.btnComentarioPrueba.Text = "Comentario Prueba";
            this.btnComentarioPrueba.UseVisualStyleBackColor = true;
            this.btnComentarioPrueba.Click += new System.EventHandler(this.btnComentarioPrueba_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnNewPost);
            this.panelLeft.Controls.Add(this.btnComentarioPrueba);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 981);
            this.panelLeft.TabIndex = 22;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnEditProfilePicture);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1019, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 981);
            this.panelRight.TabIndex = 25;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.AutoSize = true;
            this.PanelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(200, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(819, 981);
            this.PanelPrincipal.TabIndex = 26;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1219, 981);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "Profile";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComentarioPrueba;
        private System.Windows.Forms.Button btnEditProfilePicture;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}