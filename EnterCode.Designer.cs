namespace GameFacePrototype
{
    partial class EnterCode
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
            this.lblSenEmailComplete = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.tbEnterCode = new System.Windows.Forms.TextBox();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.lblAuxiliar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSenEmailComplete
            // 
            this.lblSenEmailComplete.AutoSize = true;
            this.lblSenEmailComplete.Location = new System.Drawing.Point(295, 111);
            this.lblSenEmailComplete.Name = "lblSenEmailComplete";
            this.lblSenEmailComplete.Size = new System.Drawing.Size(139, 13);
            this.lblSenEmailComplete.TabIndex = 0;
            this.lblSenEmailComplete.Text = "Se envio el codigo al correo";
            this.lblSenEmailComplete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(434, 111);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(0, 13);
            this.lblComplete.TabIndex = 1;
            // 
            // tbEnterCode
            // 
            this.tbEnterCode.Location = new System.Drawing.Point(298, 167);
            this.tbEnterCode.Name = "tbEnterCode";
            this.tbEnterCode.Size = new System.Drawing.Size(179, 20);
            this.tbEnterCode.TabIndex = 2;
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(359, 226);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyCode.TabIndex = 3;
            this.btnVerifyCode.Text = "Verificar";
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // lblAuxiliar
            // 
            this.lblAuxiliar.AutoSize = true;
            this.lblAuxiliar.Location = new System.Drawing.Point(356, 321);
            this.lblAuxiliar.Name = "lblAuxiliar";
            this.lblAuxiliar.Size = new System.Drawing.Size(0, 13);
            this.lblAuxiliar.TabIndex = 4;
            // 
            // EnterCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAuxiliar);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.tbEnterCode);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.lblSenEmailComplete);
            this.Name = "EnterCode";
            this.Text = "EnterCode";
            this.Load += new System.EventHandler(this.EnterCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenEmailComplete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.TextBox tbEnterCode;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.Label lblAuxiliar;
    }
}