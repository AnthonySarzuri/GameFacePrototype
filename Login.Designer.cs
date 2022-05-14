
namespace GameFacePrototype
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordEmpty = new System.Windows.Forms.Label();
            this.lblUserEmpty = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblPasswordGet = new System.Windows.Forms.Label();
            this.timerOut = new System.Windows.Forms.Timer(this.components);
            this.btnCloseLoginButton = new System.Windows.Forms.Button();
            this.btnLogin = new GameFacePrototype.Personalizado.Boton();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(282, 161);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(189, 20);
            this.tbUser.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(282, 241);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(189, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lblPasswordEmpty
            // 
            this.lblPasswordEmpty.AutoSize = true;
            this.lblPasswordEmpty.Location = new System.Drawing.Point(366, 264);
            this.lblPasswordEmpty.Name = "lblPasswordEmpty";
            this.lblPasswordEmpty.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordEmpty.TabIndex = 3;
            // 
            // lblUserEmpty
            // 
            this.lblUserEmpty.AutoSize = true;
            this.lblUserEmpty.Location = new System.Drawing.Point(366, 184);
            this.lblUserEmpty.Name = "lblUserEmpty";
            this.lblUserEmpty.Size = new System.Drawing.Size(0, 13);
            this.lblUserEmpty.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(279, 383);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 5;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(279, 419);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(205, 13);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "¿¡No tienes una cuenta aún!? ¡Registrate!";
            this.lblRegister.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasswordGet
            // 
            this.lblPasswordGet.AutoSize = true;
            this.lblPasswordGet.Location = new System.Drawing.Point(309, 308);
            this.lblPasswordGet.Name = "lblPasswordGet";
            this.lblPasswordGet.Size = new System.Drawing.Size(131, 13);
            this.lblPasswordGet.TabIndex = 8;
            this.lblPasswordGet.Text = "¿Olvidaste tu contraseña?";
            this.lblPasswordGet.Click += new System.EventHandler(this.lblPasswordGet_Click);
            // 
            // timerOut
            // 
            this.timerOut.Interval = 1000;
            this.timerOut.Tick += new System.EventHandler(this.timerOut_Tick);
            // 
            // btnCloseLoginButton
            // 
            this.btnCloseLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginButton.Location = new System.Drawing.Point(752, 12);
            this.btnCloseLoginButton.Name = "btnCloseLoginButton";
            this.btnCloseLoginButton.Size = new System.Drawing.Size(30, 30);
            this.btnCloseLoginButton.TabIndex = 10;
            this.btnCloseLoginButton.Text = "x";
            this.btnCloseLoginButton.UseVisualStyleBackColor = true;
            this.btnCloseLoginButton.Click += new System.EventHandler(this.btnCloseLoginButton_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(302, 356);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "boton1";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 496);
            this.Controls.Add(this.btnCloseLoginButton);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswordGet);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblUserEmpty);
            this.Controls.Add(this.lblPasswordEmpty);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPasswordEmpty;
        private System.Windows.Forms.Label lblUserEmpty;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblPasswordGet;
        private System.Windows.Forms.Timer timerOut;
        private Personalizado.Boton btnLogin;
        private System.Windows.Forms.Button btnCloseLoginButton;
    }
}