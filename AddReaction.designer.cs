
namespace GameFacePrototype
{
    partial class AddReaction
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
            this.TBreaction = new System.Windows.Forms.TextBox();
            this.BTNaddReaction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBreaction
            // 
            this.TBreaction.Location = new System.Drawing.Point(351, 189);
            this.TBreaction.Name = "TBreaction";
            this.TBreaction.Size = new System.Drawing.Size(100, 20);
            this.TBreaction.TabIndex = 0;
            // 
            // BTNaddReaction
            // 
            this.BTNaddReaction.Location = new System.Drawing.Point(351, 234);
            this.BTNaddReaction.Name = "BTNaddReaction";
            this.BTNaddReaction.Size = new System.Drawing.Size(100, 23);
            this.BTNaddReaction.TabIndex = 1;
            this.BTNaddReaction.Text = "Añadir Reacción";
            this.BTNaddReaction.UseVisualStyleBackColor = true;
            this.BTNaddReaction.Click += new System.EventHandler(this.BTNaddReaction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(758, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BTNaddReaction);
            this.Controls.Add(this.TBreaction);
            this.Name = "AddReaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBreaction;
        private System.Windows.Forms.Button BTNaddReaction;
        private System.Windows.Forms.Button btnClose;
    }
}