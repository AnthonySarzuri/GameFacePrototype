
namespace GameFacePrototype
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.TBUserEdit = new System.Windows.Forms.TextBox();
            this.TBPhoneEdit = new System.Windows.Forms.TextBox();
            this.TBMailEdit = new System.Windows.Forms.TextBox();
            this.BTNPasswordChange = new System.Windows.Forms.Button();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.DTPbirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUserEdit
            // 
            this.TBUserEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserEdit.Location = new System.Drawing.Point(281, 85);
            this.TBUserEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TBUserEdit.Name = "TBUserEdit";
            this.TBUserEdit.Size = new System.Drawing.Size(264, 34);
            this.TBUserEdit.TabIndex = 0;
            // 
            // TBPhoneEdit
            // 
            this.TBPhoneEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPhoneEdit.Location = new System.Drawing.Point(281, 157);
            this.TBPhoneEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TBPhoneEdit.Name = "TBPhoneEdit";
            this.TBPhoneEdit.Size = new System.Drawing.Size(120, 30);
            this.TBPhoneEdit.TabIndex = 1;
            this.TBPhoneEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPhoneEdit_KeyPress);
            // 
            // TBMailEdit
            // 
            this.TBMailEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMailEdit.Location = new System.Drawing.Point(281, 216);
            this.TBMailEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TBMailEdit.Name = "TBMailEdit";
            this.TBMailEdit.Size = new System.Drawing.Size(202, 34);
            this.TBMailEdit.TabIndex = 3;
            // 
            // BTNPasswordChange
            // 
            this.BTNPasswordChange.Location = new System.Drawing.Point(299, 358);
            this.BTNPasswordChange.Margin = new System.Windows.Forms.Padding(2);
            this.BTNPasswordChange.Name = "BTNPasswordChange";
            this.BTNPasswordChange.Size = new System.Drawing.Size(139, 29);
            this.BTNPasswordChange.TabIndex = 4;
            this.BTNPasswordChange.Text = "Cambiar Contraseña";
            this.BTNPasswordChange.UseVisualStyleBackColor = true;
            this.BTNPasswordChange.Click += new System.EventHandler(this.BTNPasswordChange_Click);
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(40, 85);
            this.PBProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Size = new System.Drawing.Size(146, 141);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 5;
            this.PBProfilePicture.TabStop = false;
            this.PBProfilePicture.Click += new System.EventHandler(this.PBProfilePicture_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(12, 364);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProfile.TabIndex = 6;
            this.btnDeleteProfile.Text = "Borrar Perfil";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(319, 309);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(100, 23);
            this.btnEditProfile.TabIndex = 7;
            this.btnEditProfile.Text = "ConfirmarCambios";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // DTPbirthday
            // 
            this.DTPbirthday.Location = new System.Drawing.Point(420, 160);
            this.DTPbirthday.Name = "DTPbirthday";
            this.DTPbirthday.Size = new System.Drawing.Size(200, 20);
            this.DTPbirthday.TabIndex = 8;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.DTPbirthday);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.PBProfilePicture);
            this.Controls.Add(this.BTNPasswordChange);
            this.Controls.Add(this.TBMailEdit);
            this.Controls.Add(this.TBPhoneEdit);
            this.Controls.Add(this.TBUserEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUserEdit;
        private System.Windows.Forms.TextBox TBPhoneEdit;
        private System.Windows.Forms.TextBox TBMailEdit;
        private System.Windows.Forms.Button BTNPasswordChange;
        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.DateTimePicker DTPbirthday;
    }
}