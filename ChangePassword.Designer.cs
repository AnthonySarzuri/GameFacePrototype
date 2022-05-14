﻿namespace GameFacePrototype
{
    partial class ChangePassword
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
            this.btnSHPassword = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnCloseRegisterUser = new System.Windows.Forms.Button();
            this.tbIntroducePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSHPassword
            // 
            this.btnSHPassword.Location = new System.Drawing.Point(400, 91);
            this.btnSHPassword.Name = "btnSHPassword";
            this.btnSHPassword.Size = new System.Drawing.Size(120, 23);
            this.btnSHPassword.TabIndex = 13;
            this.btnSHPassword.Text = "Mostrar Contraseña";
            this.btnSHPassword.UseVisualStyleBackColor = true;
            this.btnSHPassword.Click += new System.EventHandler(this.btnSHPassword_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(205, 246);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(122, 23);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "Verificar Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepeatPassword.Location = new System.Drawing.Point(154, 206);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.PasswordChar = '*';
            this.tbRepeatPassword.ReadOnly = true;
            this.tbRepeatPassword.Size = new System.Drawing.Size(227, 24);
            this.tbRepeatPassword.TabIndex = 15;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(154, 148);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.ReadOnly = true;
            this.tbNewPassword.Size = new System.Drawing.Size(227, 24);
            this.tbNewPassword.TabIndex = 14;
            // 
            // btnCloseRegisterUser
            // 
            this.btnCloseRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseRegisterUser.Location = new System.Drawing.Point(541, 13);
            this.btnCloseRegisterUser.Name = "btnCloseRegisterUser";
            this.btnCloseRegisterUser.Size = new System.Drawing.Size(30, 30);
            this.btnCloseRegisterUser.TabIndex = 17;
            this.btnCloseRegisterUser.Text = "x";
            this.btnCloseRegisterUser.UseVisualStyleBackColor = true;
            this.btnCloseRegisterUser.Click += new System.EventHandler(this.btnCloseRegisterUser_Click);
            // 
            // tbIntroducePassword
            // 
            this.tbIntroducePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntroducePassword.Location = new System.Drawing.Point(154, 89);
            this.tbIntroducePassword.Name = "tbIntroducePassword";
            this.tbIntroducePassword.PasswordChar = '*';
            this.tbIntroducePassword.Size = new System.Drawing.Size(227, 24);
            this.tbIntroducePassword.TabIndex = 12;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 343);
            this.Controls.Add(this.btnSHPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.btnCloseRegisterUser);
            this.Controls.Add(this.tbIntroducePassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSHPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button btnCloseRegisterUser;
        private System.Windows.Forms.TextBox tbIntroducePassword;
    }
}