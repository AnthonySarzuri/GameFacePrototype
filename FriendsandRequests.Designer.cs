namespace GameFacePrototype
{
    partial class FriendsandRequests
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
            this.tabControlFR = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNoFriends = new System.Windows.Forms.Label();
            this.flpFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNoRequests = new System.Windows.Forms.Label();
            this.flpRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlFR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFR
            // 
            this.tabControlFR.Controls.Add(this.tabPage1);
            this.tabControlFR.Controls.Add(this.tabPage2);
            this.tabControlFR.Location = new System.Drawing.Point(1, 1);
            this.tabControlFR.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlFR.Name = "tabControlFR";
            this.tabControlFR.SelectedIndex = 0;
            this.tabControlFR.Size = new System.Drawing.Size(645, 448);
            this.tabControlFR.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblNoFriends);
            this.tabPage1.Controls.Add(this.flpFriends);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(637, 422);
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
            this.flpFriends.Size = new System.Drawing.Size(628, 417);
            this.flpFriends.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNoRequests);
            this.tabPage2.Controls.Add(this.flpRequests);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(637, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Solicitudes Pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNoRequests
            // 
            this.lblNoRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRequests.Location = new System.Drawing.Point(8, 2);
            this.lblNoRequests.Name = "lblNoRequests";
            this.lblNoRequests.Size = new System.Drawing.Size(622, 23);
            this.lblNoRequests.TabIndex = 5;
            this.lblNoRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpRequests
            // 
            this.flpRequests.AutoScroll = true;
            this.flpRequests.Location = new System.Drawing.Point(4, 4);
            this.flpRequests.Margin = new System.Windows.Forms.Padding(2);
            this.flpRequests.Name = "flpRequests";
            this.flpRequests.Size = new System.Drawing.Size(626, 417);
            this.flpRequests.TabIndex = 1;
            // 
            // FriendsandRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.tabControlFR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FriendsandRequests";
            this.Text = "FriendsandRequests";
            this.tabControlFR.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFR;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNoFriends;
        private System.Windows.Forms.FlowLayoutPanel flpFriends;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNoRequests;
        private System.Windows.Forms.FlowLayoutPanel flpRequests;
    }
}