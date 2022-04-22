﻿
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
            this.TBBirthEdit = new System.Windows.Forms.TextBox();
            this.TBMailEdit = new System.Windows.Forms.TextBox();
            this.BTNPasswordChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUserEdit
            // 
            this.TBUserEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserEdit.Location = new System.Drawing.Point(281, 85);
            this.TBUserEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBUserEdit.Name = "TBUserEdit";
            this.TBUserEdit.Size = new System.Drawing.Size(264, 34);
            this.TBUserEdit.TabIndex = 0;
            this.TBUserEdit.TextChanged += new System.EventHandler(this.TBUserEdit_TextChanged);
            // 
            // TBPhoneEdit
            // 
            this.TBPhoneEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPhoneEdit.Location = new System.Drawing.Point(281, 157);
            this.TBPhoneEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPhoneEdit.Name = "TBPhoneEdit";
            this.TBPhoneEdit.Size = new System.Drawing.Size(120, 30);
            this.TBPhoneEdit.TabIndex = 1;
            this.TBPhoneEdit.TextChanged += new System.EventHandler(this.TBPhoneEdit_TextChanged);
            // 
            // TBBirthEdit
            // 
            this.TBBirthEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBirthEdit.Location = new System.Drawing.Point(455, 157);
            this.TBBirthEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBBirthEdit.Name = "TBBirthEdit";
            this.TBBirthEdit.Size = new System.Drawing.Size(90, 30);
            this.TBBirthEdit.TabIndex = 2;
            this.TBBirthEdit.TextChanged += new System.EventHandler(this.TBBirthEdit_TextChanged);
            // 
            // TBMailEdit
            // 
            this.TBMailEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMailEdit.Location = new System.Drawing.Point(281, 245);
            this.TBMailEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBMailEdit.Name = "TBMailEdit";
            this.TBMailEdit.Size = new System.Drawing.Size(202, 34);
            this.TBMailEdit.TabIndex = 3;
            this.TBMailEdit.TextChanged += new System.EventHandler(this.TBMailEdit_TextChanged);
            // 
            // BTNPasswordChange
            // 
            this.BTNPasswordChange.Location = new System.Drawing.Point(281, 318);
            this.BTNPasswordChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNPasswordChange.Name = "BTNPasswordChange";
            this.BTNPasswordChange.Size = new System.Drawing.Size(184, 45);
            this.BTNPasswordChange.TabIndex = 4;
            this.BTNPasswordChange.Text = "Cambiar Contraseña";
            this.BTNPasswordChange.UseVisualStyleBackColor = true;
            this.BTNPasswordChange.Click += new System.EventHandler(this.BTNPasswordChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNPasswordChange);
            this.Controls.Add(this.TBMailEdit);
            this.Controls.Add(this.TBBirthEdit);
            this.Controls.Add(this.TBPhoneEdit);
            this.Controls.Add(this.TBUserEdit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUserEdit;
        private System.Windows.Forms.TextBox TBPhoneEdit;
        private System.Windows.Forms.TextBox TBBirthEdit;
        private System.Windows.Forms.TextBox TBMailEdit;
        private System.Windows.Forms.Button BTNPasswordChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeleteProfile;
    }
}