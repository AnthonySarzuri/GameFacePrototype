namespace GameFacePrototype
{
    partial class RegisterUser
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
            this.btnCloseRegisterUser = new System.Windows.Forms.Button();
            this.tbRegisterEmail = new System.Windows.Forms.TextBox();
            this.tbRegisterCellphoneNumber = new System.Windows.Forms.TextBox();
            this.tbRegisterUserName = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellphoneNumber = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblObligatoryField = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnRegisterToSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseRegisterUser
            // 
            this.btnCloseRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseRegisterUser.Location = new System.Drawing.Point(758, 12);
            this.btnCloseRegisterUser.Name = "btnCloseRegisterUser";
            this.btnCloseRegisterUser.Size = new System.Drawing.Size(30, 30);
            this.btnCloseRegisterUser.TabIndex = 0;
            this.btnCloseRegisterUser.Text = "x";
            this.btnCloseRegisterUser.UseVisualStyleBackColor = true;
            this.btnCloseRegisterUser.Click += new System.EventHandler(this.btnCloseRegisterUser_Click);
            // 
            // tbRegisterEmail
            // 
            this.tbRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterEmail.Location = new System.Drawing.Point(292, 117);
            this.tbRegisterEmail.Name = "tbRegisterEmail";
            this.tbRegisterEmail.Size = new System.Drawing.Size(227, 24);
            this.tbRegisterEmail.TabIndex = 1;
            // 
            // tbRegisterCellphoneNumber
            // 
            this.tbRegisterCellphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterCellphoneNumber.Location = new System.Drawing.Point(292, 170);
            this.tbRegisterCellphoneNumber.Name = "tbRegisterCellphoneNumber";
            this.tbRegisterCellphoneNumber.Size = new System.Drawing.Size(227, 24);
            this.tbRegisterCellphoneNumber.TabIndex = 2;
            this.tbRegisterCellphoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegisterCellphoneNumber_KeyPress);
            // 
            // tbRegisterUserName
            // 
            this.tbRegisterUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterUserName.Location = new System.Drawing.Point(292, 221);
            this.tbRegisterUserName.Name = "tbRegisterUserName";
            this.tbRegisterUserName.Size = new System.Drawing.Size(227, 24);
            this.tbRegisterUserName.TabIndex = 3;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterPassword.Location = new System.Drawing.Point(292, 269);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.PasswordChar = '*';
            this.tbRegisterPassword.Size = new System.Drawing.Size(227, 24);
            this.tbRegisterPassword.TabIndex = 4;
            // 
            // tbRegisterConfirmPassword
            // 
            this.tbRegisterConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterConfirmPassword.Location = new System.Drawing.Point(292, 320);
            this.tbRegisterConfirmPassword.Name = "tbRegisterConfirmPassword";
            this.tbRegisterConfirmPassword.PasswordChar = '*';
            this.tbRegisterConfirmPassword.Size = new System.Drawing.Size(227, 24);
            this.tbRegisterConfirmPassword.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(336, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Correo electrónico*";
            // 
            // lblCellphoneNumber
            // 
            this.lblCellphoneNumber.AutoSize = true;
            this.lblCellphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphoneNumber.Location = new System.Drawing.Point(312, 149);
            this.lblCellphoneNumber.Name = "lblCellphoneNumber";
            this.lblCellphoneNumber.Size = new System.Drawing.Size(202, 18);
            this.lblCellphoneNumber.TabIndex = 7;
            this.lblCellphoneNumber.Text = "Número de celular (Opcional)";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(331, 200);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(144, 18);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Nombre de Usuario*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(356, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 18);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña*";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(331, 299);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(161, 18);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = "Confirmar Contraseña*";
            // 
            // lblObligatoryField
            // 
            this.lblObligatoryField.AutoSize = true;
            this.lblObligatoryField.Location = new System.Drawing.Point(12, 9);
            this.lblObligatoryField.Name = "lblObligatoryField";
            this.lblObligatoryField.Size = new System.Drawing.Size(97, 13);
            this.lblObligatoryField.TabIndex = 11;
            this.lblObligatoryField.Text = "Campo Obligatorio*";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.Lime;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(359, 379);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(96, 27);
            this.btnRegisterUser.TabIndex = 12;
            this.btnRegisterUser.Text = "Registrarse";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnRegisterToSignIn
            // 
            this.btnRegisterToSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterToSignIn.Location = new System.Drawing.Point(315, 415);
            this.btnRegisterToSignIn.Name = "btnRegisterToSignIn";
            this.btnRegisterToSignIn.Size = new System.Drawing.Size(188, 23);
            this.btnRegisterToSignIn.TabIndex = 13;
            this.btnRegisterToSignIn.Text = "¿Tienes una cuenta? Inicia Sesion";
            this.btnRegisterToSignIn.UseVisualStyleBackColor = false;
            this.btnRegisterToSignIn.Click += new System.EventHandler(this.btnRegisterToSignIn_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterToSignIn);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.lblObligatoryField);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCellphoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbRegisterConfirmPassword);
            this.Controls.Add(this.tbRegisterPassword);
            this.Controls.Add(this.tbRegisterUserName);
            this.Controls.Add(this.tbRegisterCellphoneNumber);
            this.Controls.Add(this.tbRegisterEmail);
            this.Controls.Add(this.btnCloseRegisterUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseRegisterUser;
        private System.Windows.Forms.TextBox tbRegisterEmail;
        private System.Windows.Forms.TextBox tbRegisterCellphoneNumber;
        private System.Windows.Forms.TextBox tbRegisterUserName;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.TextBox tbRegisterConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellphoneNumber;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblObligatoryField;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnRegisterToSignIn;
    }
}