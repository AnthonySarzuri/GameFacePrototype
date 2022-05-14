
namespace GameFacePrototype
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNIniciar = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNIniciar
            // 
            this.BTNIniciar.Location = new System.Drawing.Point(1086, 40);
            this.BTNIniciar.Name = "BTNIniciar";
            this.BTNIniciar.Size = new System.Drawing.Size(101, 23);
            this.BTNIniciar.TabIndex = 0;
            this.BTNIniciar.Text = "Iniciar Sesion";
            this.BTNIniciar.UseVisualStyleBackColor = true;
            this.BTNIniciar.Click += new System.EventHandler(this.BTNIniciar_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(1193, 40);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnRegister);
            this.topPanel.Controls.Add(this.BTNIniciar);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1304, 100);
            this.topPanel.TabIndex = 4;
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 685);
            this.leftPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1104, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 685);
            this.panel1.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(904, 685);
            this.mainPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 785);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNIniciar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

