namespace GameFacePrototype
{
    partial class CreatePostTest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.tbdescripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(196, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(316, 449);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(162, 45);
            this.btnCreatePost.TabIndex = 6;
            this.btnCreatePost.Text = "Publicar";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click_1);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(645, 449);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(187, 40);
            this.btMostrar.TabIndex = 7;
            this.btMostrar.Text = "Mostrar Publicacion";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click_1);
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(196, 58);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(399, 99);
            this.tbdescripcion.TabIndex = 8;
            this.tbdescripcion.Text = "";
            // 
            // CreatePostTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 568);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreatePostTest";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.RichTextBox tbdescripcion;
    }
}