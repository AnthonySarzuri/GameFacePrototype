﻿namespace GameFacePrototype
{
    partial class EnterEmail
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
            this.tbEnterEmail = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnterEmail
            // 
            this.tbEnterEmail.Location = new System.Drawing.Point(332, 207);
            this.tbEnterEmail.Name = "tbEnterEmail";
            this.tbEnterEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEnterEmail.Size = new System.Drawing.Size(201, 20);
            this.tbEnterEmail.TabIndex = 0;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(357, 271);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(132, 30);
            this.btnSendCode.TabIndex = 1;
            this.btnSendCode.Text = "Enviar Codigo";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa tu correo electronico";
            // 
            // EnterEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.tbEnterEmail);
            this.Name = "EnterEmail";
            this.Text = "EnterEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterEmail;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label label1;
    }
}