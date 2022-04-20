
namespace GameFacePrototype
{
    partial class EditProfile
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
            this.TBUserEdit = new System.Windows.Forms.TextBox();
            this.TBPhoneEdit = new System.Windows.Forms.TextBox();
            this.TBBirthEdit = new System.Windows.Forms.TextBox();
            this.TBMailEdit = new System.Windows.Forms.TextBox();
            this.BTNPasswordChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUserEdit
            // 
            this.TBUserEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserEdit.Location = new System.Drawing.Point(375, 105);
            this.TBUserEdit.Name = "TBUserEdit";
            this.TBUserEdit.Size = new System.Drawing.Size(351, 41);
            this.TBUserEdit.TabIndex = 0;
            this.TBUserEdit.TextChanged += new System.EventHandler(this.TBUserEdit_TextChanged);
            // 
            // TBPhoneEdit
            // 
            this.TBPhoneEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPhoneEdit.Location = new System.Drawing.Point(375, 193);
            this.TBPhoneEdit.Name = "TBPhoneEdit";
            this.TBPhoneEdit.Size = new System.Drawing.Size(159, 36);
            this.TBPhoneEdit.TabIndex = 1;
            this.TBPhoneEdit.TextChanged += new System.EventHandler(this.TBPhoneEdit_TextChanged);
            // 
            // TBBirthEdit
            // 
            this.TBBirthEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBirthEdit.Location = new System.Drawing.Point(607, 193);
            this.TBBirthEdit.Name = "TBBirthEdit";
            this.TBBirthEdit.Size = new System.Drawing.Size(119, 36);
            this.TBBirthEdit.TabIndex = 2;
            this.TBBirthEdit.TextChanged += new System.EventHandler(this.TBBirthEdit_TextChanged);
            // 
            // TBMailEdit
            // 
            this.TBMailEdit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMailEdit.Location = new System.Drawing.Point(375, 301);
            this.TBMailEdit.Name = "TBMailEdit";
            this.TBMailEdit.Size = new System.Drawing.Size(268, 41);
            this.TBMailEdit.TabIndex = 3;
            this.TBMailEdit.TextChanged += new System.EventHandler(this.TBMailEdit_TextChanged);
            // 
            // BTNPasswordChange
            // 
            this.BTNPasswordChange.Location = new System.Drawing.Point(375, 392);
            this.BTNPasswordChange.Name = "BTNPasswordChange";
            this.BTNPasswordChange.Size = new System.Drawing.Size(246, 55);
            this.BTNPasswordChange.TabIndex = 4;
            this.BTNPasswordChange.Text = "Cambiar Contraseña";
            this.BTNPasswordChange.UseVisualStyleBackColor = true;
            this.BTNPasswordChange.Click += new System.EventHandler(this.BTNPasswordChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 173);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNPasswordChange);
            this.Controls.Add(this.TBMailEdit);
            this.Controls.Add(this.TBBirthEdit);
            this.Controls.Add(this.TBPhoneEdit);
            this.Controls.Add(this.TBUserEdit);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUserEdit;
        private System.Windows.Forms.TextBox TBPhoneEdit;
        private System.Windows.Forms.TextBox TBBirthEdit;
        private System.Windows.Forms.TextBox TBMailEdit;
        private System.Windows.Forms.Button BTNPasswordChange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}