namespace GameFacePrototype
{
    partial class NewPassword
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
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(311, 108);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '+';
            this.tbNewPassword.Size = new System.Drawing.Size(174, 20);
            this.tbNewPassword.TabIndex = 0;
            // 
            // tbRepeatNewPassword
            // 
            this.tbRepeatNewPassword.Location = new System.Drawing.Point(311, 215);
            this.tbRepeatNewPassword.Name = "tbRepeatNewPassword";
            this.tbRepeatNewPassword.PasswordChar = '+';
            this.tbRepeatNewPassword.Size = new System.Drawing.Size(174, 20);
            this.tbRepeatNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repetir contraseña";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(311, 309);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(157, 40);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Cambiar contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRepeatNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbRepeatNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
    }
}