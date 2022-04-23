
namespace GameFacePrototype
{
    partial class CommentsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsTest));
            this.grbox1 = new System.Windows.Forms.GroupBox();
            this.txtcommentary = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.grbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox1
            // 
            this.grbox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox1.Controls.Add(this.txtcommentary);
            this.grbox1.Controls.Add(this.btnsend);
            this.grbox1.Controls.Add(this.btndelete);
            this.grbox1.Controls.Add(this.pbimage);
            this.grbox1.Location = new System.Drawing.Point(12, 102);
            this.grbox1.Name = "grbox1";
            this.grbox1.Size = new System.Drawing.Size(577, 112);
            this.grbox1.TabIndex = 0;
            this.grbox1.TabStop = false;
            // 
            // txtcommentary
            // 
            this.txtcommentary.Location = new System.Drawing.Point(119, 50);
            this.txtcommentary.Multiline = true;
            this.txtcommentary.Name = "txtcommentary";
            this.txtcommentary.Size = new System.Drawing.Size(407, 52);
            this.txtcommentary.TabIndex = 3;
            // 
            // btnsend
            // 
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsend.Location = new System.Drawing.Point(532, 79);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(27, 23);
            this.btnsend.TabIndex = 2;
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.Location = new System.Drawing.Point(532, 50);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(27, 23);
            this.btndelete.TabIndex = 1;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pbimage
            // 
            this.pbimage.Image = ((System.Drawing.Image)(resources.GetObject("pbimage.Image")));
            this.pbimage.Location = new System.Drawing.Point(6, 10);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(98, 92);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 0;
            this.pbimage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbox1.ResumeLayout(false);
            this.grbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox1;
        private System.Windows.Forms.TextBox txtcommentary;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.PictureBox pbimage;
    }
}

