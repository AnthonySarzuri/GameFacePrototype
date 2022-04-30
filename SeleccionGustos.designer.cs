namespace GameFacePrototype
{
    partial class SeleccionGustos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionGustos));
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThriller = new System.Windows.Forms.CheckBox();
            this.cbAction = new System.Windows.Forms.CheckBox();
            this.cbArcade = new System.Windows.Forms.CheckBox();
            this.cbSports = new System.Windows.Forms.CheckBox();
            this.cbRPG = new System.Windows.Forms.CheckBox();
            this.cbSimulators = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(81, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 13);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "¿Que te gusta?";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(84, 187);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(77, 23);
            this.btnconfirm.TabIndex = 21;
            this.btnconfirm.Text = "confirmar";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "selecciona por lo menos 3 categorias";
            // 
            // cbThriller
            // 
            this.cbThriller.AutoSize = true;
            this.cbThriller.Image = ((System.Drawing.Image)(resources.GetObject("cbThriller.Image")));
            this.cbThriller.Location = new System.Drawing.Point(326, 58);
            this.cbThriller.Name = "cbThriller";
            this.cbThriller.Size = new System.Drawing.Size(115, 100);
            this.cbThriller.TabIndex = 33;
            this.cbThriller.UseVisualStyleBackColor = true;
            this.cbThriller.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbAction
            // 
            this.cbAction.AutoSize = true;
            this.cbAction.Image = ((System.Drawing.Image)(resources.GetObject("cbAction.Image")));
            this.cbAction.Location = new System.Drawing.Point(447, 58);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(115, 100);
            this.cbAction.TabIndex = 34;
            this.cbAction.UseVisualStyleBackColor = true;
            this.cbAction.CheckedChanged += new System.EventHandler(this.cbAction_CheckedChanged);
            // 
            // cbArcade
            // 
            this.cbArcade.AutoSize = true;
            this.cbArcade.Image = ((System.Drawing.Image)(resources.GetObject("cbArcade.Image")));
            this.cbArcade.Location = new System.Drawing.Point(568, 58);
            this.cbArcade.Name = "cbArcade";
            this.cbArcade.Size = new System.Drawing.Size(115, 100);
            this.cbArcade.TabIndex = 35;
            this.cbArcade.UseVisualStyleBackColor = true;
            this.cbArcade.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbSports
            // 
            this.cbSports.AutoSize = true;
            this.cbSports.Image = ((System.Drawing.Image)(resources.GetObject("cbSports.Image")));
            this.cbSports.Location = new System.Drawing.Point(326, 187);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(115, 100);
            this.cbSports.TabIndex = 36;
            this.cbSports.UseVisualStyleBackColor = true;
            this.cbSports.CheckedChanged += new System.EventHandler(this.cbSports_CheckedChanged);
            // 
            // cbRPG
            // 
            this.cbRPG.AutoSize = true;
            this.cbRPG.Image = ((System.Drawing.Image)(resources.GetObject("cbRPG.Image")));
            this.cbRPG.Location = new System.Drawing.Point(447, 187);
            this.cbRPG.Name = "cbRPG";
            this.cbRPG.Size = new System.Drawing.Size(115, 100);
            this.cbRPG.TabIndex = 37;
            this.cbRPG.UseVisualStyleBackColor = true;
            this.cbRPG.CheckedChanged += new System.EventHandler(this.cbRPG_CheckedChanged);
            // 
            // cbSimulators
            // 
            this.cbSimulators.AutoSize = true;
            this.cbSimulators.Image = ((System.Drawing.Image)(resources.GetObject("cbSimulators.Image")));
            this.cbSimulators.Location = new System.Drawing.Point(568, 187);
            this.cbSimulators.Name = "cbSimulators";
            this.cbSimulators.Size = new System.Drawing.Size(115, 100);
            this.cbSimulators.TabIndex = 38;
            this.cbSimulators.UseVisualStyleBackColor = true;
            this.cbSimulators.CheckedChanged += new System.EventHandler(this.cbSimulators_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thriller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Accion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Arcade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Deportes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "RPG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Simulacion";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(291, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 283);
            this.panel1.TabIndex = 45;
            // 
            // SeleccionGustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 631);
            this.Controls.Add(this.cbArcade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbThriller);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSports);
            this.Controls.Add(this.cbSimulators);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRPG);
            this.Name = "SeleccionGustos";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbThriller;
        private System.Windows.Forms.CheckBox cbAction;
        private System.Windows.Forms.CheckBox cbArcade;
        private System.Windows.Forms.CheckBox cbSports;
        private System.Windows.Forms.CheckBox cbRPG;
        private System.Windows.Forms.CheckBox cbSimulators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}