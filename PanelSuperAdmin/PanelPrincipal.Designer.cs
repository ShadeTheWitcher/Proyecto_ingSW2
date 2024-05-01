namespace Proyecto_Taller_AdminShop
{
    partial class PanelPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RU = new System.Windows.Forms.Button();
            this.IB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.RU);
            this.panel1.Controls.Add(this.IB);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 407);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RU
            // 
            this.RU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.RU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RU.FlatAppearance.BorderSize = 0;
            this.RU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RU.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RU.ForeColor = System.Drawing.Color.White;
            this.RU.Location = new System.Drawing.Point(-20, 84);
            this.RU.Name = "RU";
            this.RU.Size = new System.Drawing.Size(211, 38);
            this.RU.TabIndex = 1;
            this.RU.Text = "Registrar Usuario";
            this.RU.UseVisualStyleBackColor = false;
            this.RU.Click += new System.EventHandler(this.RU_Click);
            // 
            // IB
            // 
            this.IB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.IB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB.FlatAppearance.BorderSize = 0;
            this.IB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB.ForeColor = System.Drawing.Color.White;
            this.IB.Location = new System.Drawing.Point(0, 40);
            this.IB.Name = "IB";
            this.IB.Size = new System.Drawing.Size(179, 38);
            this.IB.TabIndex = 0;
            this.IB.Text = "Inicio";
            this.IB.UseVisualStyleBackColor = false;
            this.IB.Click += new System.EventHandler(this.IB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-9, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(688, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminShop";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel3.Location = new System.Drawing.Point(176, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 390);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "PanelPrincipal";
            this.Text = "PanelPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button IB;
        private System.Windows.Forms.Button RU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}