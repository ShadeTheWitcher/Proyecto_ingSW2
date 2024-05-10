namespace Proyecto_Taller_AdminShop.Vendedor
{
    partial class PanelVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelVendedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RC = new System.Windows.Forms.Button();
            this.CV = new System.Windows.Forms.Button();
            this.RV = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RC);
            this.panel1.Controls.Add(this.CV);
            this.panel1.Controls.Add(this.RV);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 407);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel3.Location = new System.Drawing.Point(180, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 390);
            this.panel3.TabIndex = 6;
            // 
            // RC
            // 
            this.RC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.RC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RC.FlatAppearance.BorderSize = 0;
            this.RC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RC.ForeColor = System.Drawing.Color.White;
            this.RC.Location = new System.Drawing.Point(-17, 118);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(211, 38);
            this.RC.TabIndex = 2;
            this.RC.Text = "Registrar Cliente";
            this.RC.UseVisualStyleBackColor = false;
            this.RC.Click += new System.EventHandler(this.button1_Click);
            // 
            // CV
            // 
            this.CV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.CV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CV.FlatAppearance.BorderSize = 0;
            this.CV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV.ForeColor = System.Drawing.Color.White;
            this.CV.Location = new System.Drawing.Point(-19, 72);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(211, 38);
            this.CV.TabIndex = 1;
            this.CV.Text = "Consultar Venta";
            this.CV.UseVisualStyleBackColor = false;
            this.CV.Click += new System.EventHandler(this.RU_Click);
            // 
            // RV
            // 
            this.RV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.RV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RV.FlatAppearance.BorderSize = 0;
            this.RV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RV.ForeColor = System.Drawing.Color.White;
            this.RV.Location = new System.Drawing.Point(-17, 31);
            this.RV.Name = "RV";
            this.RV.Size = new System.Drawing.Size(211, 38);
            this.RV.TabIndex = 0;
            this.RV.Text = "Registrar Venta";
            this.RV.UseVisualStyleBackColor = false;
            this.RV.Click += new System.EventHandler(this.IB_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panelPrincipal.Location = new System.Drawing.Point(180, 67);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(955, 789);
            this.panelPrincipal.TabIndex = 6;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 67);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(689, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminShop";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(538, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cerrar Sesión";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelVendedor";
            this.Text = "Panel Vendedor";
            this.Load += new System.EventHandler(this.PanelVendedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RC;
        private System.Windows.Forms.Button CV;
        private System.Windows.Forms.Button RV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}