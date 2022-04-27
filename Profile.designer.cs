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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.btnNewPost = new System.Windows.Forms.Button();
            this.btnEditProfilePicture = new System.Windows.Forms.Button();
            this.btnComentarioPrueba = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.AutoSize = true;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(200, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1019, 981);
            this.PanelPrincipal.TabIndex = 21;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewPost);
            this.panel1.Controls.Add(this.btnComentarioPrueba);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 981);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditProfilePicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1019, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 981);
            this.panel2.TabIndex = 25;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1219, 981);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnComentarioPrueba;
        private System.Windows.Forms.Button btnEditProfilePicture;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}