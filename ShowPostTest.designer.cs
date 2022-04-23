namespace GameFacePrototype
{
    partial class ShowPostTest
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
            this.btnComentarioPrueba = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.AutoScroll = true;
            this.PanelPrincipal.AutoSize = true;
            this.PanelPrincipal.Controls.Add(this.btnBack);
            this.PanelPrincipal.Controls.Add(this.btnComentarioPrueba);
            this.PanelPrincipal.Controls.Add(this.btnMostrar);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1093, 1061);
            this.PanelPrincipal.TabIndex = 21;
            // 
            // btnComentarioPrueba
            // 
            this.btnComentarioPrueba.Location = new System.Drawing.Point(41, 833);
            this.btnComentarioPrueba.Name = "btnComentarioPrueba";
            this.btnComentarioPrueba.Size = new System.Drawing.Size(180, 59);
            this.btnComentarioPrueba.TabIndex = 22;
            this.btnComentarioPrueba.Text = "Comentario Prueba";
            this.btnComentarioPrueba.UseVisualStyleBackColor = true;
            this.btnComentarioPrueba.Click += new System.EventHandler(this.btnComentarioPrueba_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(41, 710);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 66);
            this.btnMostrar.TabIndex = 21;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(41, 926);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 68);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShowPostTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1093, 1061);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "ShowPostTest";
            this.Text = "Form1";
            this.PanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button btnComentarioPrueba;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBack;
    }
}