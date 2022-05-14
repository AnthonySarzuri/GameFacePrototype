
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateInterface));
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.LBLShowUserId = new System.Windows.Forms.Label();
            this.PBProfilePicture = new System.Windows.Forms.PictureBox();
            this.LBLShowUser = new System.Windows.Forms.Label();
            this.btnRefreshNewPost = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnNewPosts = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tmrefreshNewPosts = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1404, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(189, 460);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 217);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 213);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(251, 181);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 20);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(207, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 20);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(28, 181);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(173, 20);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnAdminMenu);
            this.panelTop.Controls.Add(this.LBLShowUserId);
            this.panelTop.Controls.Add(this.PBProfilePicture);
            this.panelTop.Controls.Add(this.LBLShowUser);
            this.panelTop.Controls.Add(this.btnRefreshNewPost);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1443, 127);
            this.panelTop.TabIndex = 6;
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(1247, 98);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAdminMenu.TabIndex = 12;
            this.btnAdminMenu.Text = "Menu Admin";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Visible = false;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // LBLShowUserId
            // 
            this.LBLShowUserId.AutoSize = true;
            this.LBLShowUserId.Location = new System.Drawing.Point(1244, 70);
            this.LBLShowUserId.Name = "LBLShowUserId";
            this.LBLShowUserId.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUserId.TabIndex = 41;
            this.LBLShowUserId.Text = "label2";
            this.LBLShowUserId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBLShowUserId.Click += new System.EventHandler(this.LBLShowUserId_Click);
            // 
            // PBProfilePicture
            // 
            this.PBProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("PBProfilePicture.Image")));
            this.PBProfilePicture.Location = new System.Drawing.Point(1345, 39);
            this.PBProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.PBProfilePicture.Name = "PBProfilePicture";
            this.PBProfilePicture.Size = new System.Drawing.Size(96, 83);
            this.PBProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProfilePicture.TabIndex = 39;
            this.PBProfilePicture.TabStop = false;
            this.PBProfilePicture.Click += new System.EventHandler(this.PBProfilePicture_Click);
            // 
            // LBLShowUser
            // 
            this.LBLShowUser.AutoSize = true;
            this.LBLShowUser.Location = new System.Drawing.Point(1244, 45);
            this.LBLShowUser.Name = "LBLShowUser";
            this.LBLShowUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLShowUser.Size = new System.Drawing.Size(35, 13);
            this.LBLShowUser.TabIndex = 40;
            this.LBLShowUser.Text = "label1";
            this.LBLShowUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBLShowUser.Click += new System.EventHandler(this.LBLShowUser_Click);
            // 
            // btnRefreshNewPost
            // 
            this.btnRefreshNewPost.Location = new System.Drawing.Point(595, 40);
            this.btnRefreshNewPost.Name = "btnRefreshNewPost";
            this.btnRefreshNewPost.Size = new System.Drawing.Size(216, 38);
            this.btnRefreshNewPost.TabIndex = 0;
            this.btnRefreshNewPost.Text = "Cargar mas comentarios";
            this.btnRefreshNewPost.UseVisualStyleBackColor = true;
            this.btnRefreshNewPost.Visible = false;
            this.btnRefreshNewPost.Click += new System.EventHandler(this.btnRefreshNewPost_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 127);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(302, 730);
            this.panelLeft.TabIndex = 7;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnNewPosts);
            this.panelRight.Controls.Add(this.lblNotFound);
            this.panelRight.Controls.Add(this.btnRefresh);
            this.panelRight.Controls.Add(this.flowLayoutPanel1);
            this.panelRight.Controls.Add(this.tbSearch);
            this.panelRight.Controls.Add(this.btnBuscar);
            this.panelRight.Controls.Add(this.btnLimpiar);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1145, 127);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(298, 730);
            this.panelRight.TabIndex = 11;
            // 
            // btnNewPosts
            // 
            this.btnNewPosts.Location = new System.Drawing.Point(101, 511);
            this.btnNewPosts.Name = "btnNewPosts";
            this.btnNewPosts.Size = new System.Drawing.Size(184, 23);
            this.btnNewPosts.TabIndex = 11;
            this.btnNewPosts.Text = "Cargar mas comentarios";
            this.btnNewPosts.UseVisualStyleBackColor = true;
            this.btnNewPosts.Click += new System.EventHandler(this.btnNewPosts_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Location = new System.Drawing.Point(21, 417);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(0, 13);
            this.lblNotFound.TabIndex = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(302, 127);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(843, 730);
            this.mainPanel.TabIndex = 12;
            // 
            // tmrefreshNewPosts
            // 
            this.tmrefreshNewPosts.Enabled = true;
            this.tmrefreshNewPosts.Interval = 30000;
            this.tmrefreshNewPosts.Tick += new System.EventHandler(this.tmrefreshNewPosts_Tick);
            // 
            // PrivateInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrivateInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrivateInterface";
            this.Load += new System.EventHandler(this.PrivateInterface_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProfilePicture)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Button btnRefreshNewPost;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer tmrefreshNewPosts;
        private System.Windows.Forms.Button btnNewPosts;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.Label LBLShowUserId;
        private System.Windows.Forms.PictureBox PBProfilePicture;
        private System.Windows.Forms.Label LBLShowUser;
    }
}