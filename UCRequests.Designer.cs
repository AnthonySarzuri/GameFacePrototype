namespace GameFacePrototype
{
    partial class UCRequests
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
            this.btnaccFriend = new System.Windows.Forms.Button();
            this.btndelFReq = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(409, 24);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 18;
            // 
            // btnaccFriend
            // 
            this.btnaccFriend.Location = new System.Drawing.Point(352, 46);
            this.btnaccFriend.Margin = new System.Windows.Forms.Padding(2);
            this.btnaccFriend.Name = "btnaccFriend";
            this.btnaccFriend.Size = new System.Drawing.Size(102, 21);
            this.btnaccFriend.TabIndex = 17;
            this.btnaccFriend.Text = "Aceptar Solicitud";
            this.btnaccFriend.UseVisualStyleBackColor = true;
            this.btnaccFriend.Click += new System.EventHandler(this.btnaccFriend_Click);
            // 
            // btndelFReq
            // 
            this.btndelFReq.Location = new System.Drawing.Point(467, 46);
            this.btndelFReq.Margin = new System.Windows.Forms.Padding(2);
            this.btndelFReq.Name = "btndelFReq";
            this.btndelFReq.Size = new System.Drawing.Size(110, 21);
            this.btndelFReq.TabIndex = 16;
            this.btndelFReq.Text = "Eliminar Solicitud";
            this.btndelFReq.UseVisualStyleBackColor = true;
            this.btndelFReq.Click += new System.EventHandler(this.btndelFReq_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Location = new System.Drawing.Point(125, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(198, 29);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Lorem Ipsum";
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(125, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(198, 26);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(16, 14);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(84, 80);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePic.TabIndex = 13;
            this.pbProfilePic.TabStop = false;
            // 
            // UCRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnaccFriend);
            this.Controls.Add(this.btndelFReq);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbProfilePic);
            this.Name = "UCRequests";
            this.Size = new System.Drawing.Size(593, 109);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnaccFriend;
        private System.Windows.Forms.Button btndelFReq;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbProfilePic;
    }
}
