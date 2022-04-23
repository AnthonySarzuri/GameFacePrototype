
namespace GameFacePrototype
{
    partial class PrivateInterface
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnMostrarPosts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(334, 127);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(56, 19);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Editar";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnMostrarPosts
            // 
            this.btnMostrarPosts.Location = new System.Drawing.Point(71, 285);
            this.btnMostrarPosts.Name = "btnMostrarPosts";
            this.btnMostrarPosts.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPosts.TabIndex = 1;
            this.btnMostrarPosts.Text = "Prueba Posts";
            this.btnMostrarPosts.UseVisualStyleBackColor = true;
            this.btnMostrarPosts.Click += new System.EventHandler(this.btnMostrarPosts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrivateInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarPosts);
            this.Controls.Add(this.btnEditProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrivateInterface";
            this.Text = "PrivateInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnMostrarPosts;
        private System.Windows.Forms.Button button1;
    }
}