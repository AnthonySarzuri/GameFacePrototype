
namespace GameFacePrototype
{
    partial class UserFriendsChat
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblState = new System.Windows.Forms.Label();
            this.btnChatFriend = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(778, 140);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 17);
            this.lblState.TabIndex = 23;
            // 
            // btnChatFriend
            // 
            this.btnChatFriend.Location = new System.Drawing.Point(227, 13);
            this.btnChatFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChatFriend.Name = "btnChatFriend";
            this.btnChatFriend.Size = new System.Drawing.Size(51, 27);
            this.btnChatFriend.TabIndex = 22;
            this.btnChatFriend.Text = "Chat";
            this.btnChatFriend.UseVisualStyleBackColor = true;
            this.btnChatFriend.Click += new System.EventHandler(this.btndelFriend_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Location = new System.Drawing.Point(87, 42);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 24);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Lorem Ipsum";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(85, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 22);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(17, 11);
            this.pbProfilePic.Margin = new System.Windows.Forms.Padding(4);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(51, 43);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePic.TabIndex = 19;
            this.pbProfilePic.TabStop = false;
            // 
            // UserFriendsChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnChatFriend);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbProfilePic);
            this.Name = "UserFriendsChat";
            this.Size = new System.Drawing.Size(289, 77);
            this.Load += new System.EventHandler(this.UserFriendsChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnChatFriend;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbProfilePic;
    }
}
