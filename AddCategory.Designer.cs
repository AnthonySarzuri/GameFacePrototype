namespace GameFacePrototype
{
    partial class AddCategory
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.TBCategoryName = new System.Windows.Forms.TextBox();
            this.TBCategoryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(367, 338);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Confirmar";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // TBCategoryName
            // 
            this.TBCategoryName.Location = new System.Drawing.Point(333, 141);
            this.TBCategoryName.Name = "TBCategoryName";
            this.TBCategoryName.Size = new System.Drawing.Size(138, 20);
            this.TBCategoryName.TabIndex = 1;
            // 
            // TBCategoryDescription
            // 
            this.TBCategoryDescription.Location = new System.Drawing.Point(333, 187);
            this.TBCategoryDescription.Name = "TBCategoryDescription";
            this.TBCategoryDescription.Size = new System.Drawing.Size(138, 20);
            this.TBCategoryDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción:";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCategoryDescription);
            this.Controls.Add(this.TBCategoryName);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox TBCategoryName;
        private System.Windows.Forms.TextBox TBCategoryDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}