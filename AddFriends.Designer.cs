namespace GameFacePrototype
{
    partial class AddFriends
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeeProfile = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeProfile
            // 
            this.btnSeeProfile.Location = new System.Drawing.Point(215, 29);
            this.btnSeeProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeProfile.Name = "btnSeeProfile";
            this.btnSeeProfile.Size = new System.Drawing.Size(79, 25);
            this.btnSeeProfile.TabIndex = 15;
            this.btnSeeProfile.Text = "Ver Perfil";
            this.btnSeeProfile.UseVisualStyleBackColor = true;
            this.btnSeeProfile.Click += new System.EventHandler(this.btnSeeProfile_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(97, 38);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 16);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(99, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "label1";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfilePic.Location = new System.Drawing.Point(4, 4);
            this.pbProfilePic.Margin = new System.Windows.Forms.Padding(4);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(87, 74);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 12;
            this.pbProfilePic.TabStop = false;
            // 
            // AddFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSeeProfile);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbProfilePic);
            this.Name = "AddFriends";
            this.Size = new System.Drawing.Size(324, 83);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeeProfile;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbProfilePic;
    }
}
