
namespace GameFacePrototype
{
    partial class Conversation
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(145, 391);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(325, 20);
            this.txtMensaje.TabIndex = 4;
            this.txtMensaje.Text = " ";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(489, 388);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "ENVIAR";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(49, 30);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // panelChat
            // 
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelChat.Location = new System.Drawing.Point(0, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(674, 366);
            this.panelChat.TabIndex = 6;
            this.panelChat.WrapContents = false;
            // 
            // Conversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 587);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.listBox1);
            this.Name = "Conversation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel panelChat;
    }
}

