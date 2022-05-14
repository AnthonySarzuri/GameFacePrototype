
namespace GameFacePrototype
{
    partial class Chat
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNoFriends = new System.Windows.Forms.Label();
            this.flpFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlFR = new System.Windows.Forms.TabControl();
            this.panelChat = new System.Windows.Forms.Panel();
            this.tabPage1.SuspendLayout();
            this.tabControlFR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelChat);
            this.tabPage1.Controls.Add(this.lblNoFriends);
            this.tabPage1.Controls.Add(this.flpFriends);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(847, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amigos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNoFriends
            // 
            this.lblNoFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFriends.Location = new System.Drawing.Point(10, 2);
            this.lblNoFriends.Name = "lblNoFriends";
            this.lblNoFriends.Size = new System.Drawing.Size(622, 23);
            this.lblNoFriends.TabIndex = 4;
            this.lblNoFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpFriends
            // 
            this.flpFriends.AutoScroll = true;
            this.flpFriends.Location = new System.Drawing.Point(4, 4);
            this.flpFriends.Margin = new System.Windows.Forms.Padding(2);
            this.flpFriends.Name = "flpFriends";
            this.flpFriends.Size = new System.Drawing.Size(208, 521);
            this.flpFriends.TabIndex = 1;
            this.flpFriends.Paint += new System.Windows.Forms.PaintEventHandler(this.flpFriends_Paint);
            // 
            // tabControlFR
            // 
            this.tabControlFR.Controls.Add(this.tabPage1);
            this.tabControlFR.Location = new System.Drawing.Point(97, 11);
            this.tabControlFR.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlFR.Name = "tabControlFR";
            this.tabControlFR.SelectedIndex = 0;
            this.tabControlFR.Size = new System.Drawing.Size(855, 555);
            this.tabControlFR.TabIndex = 2;
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChat.Location = new System.Drawing.Point(217, 2);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(628, 525);
            this.panelChat.TabIndex = 5;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 592);
            this.Controls.Add(this.tabControlFR);
            this.Name = "Chat";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControlFR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNoFriends;
        private System.Windows.Forms.FlowLayoutPanel flpFriends;
        private System.Windows.Forms.TabControl tabControlFR;
        public  System.Windows.Forms.Panel panelChat;
    }
}