namespace Proyecto_Taller_AdminShop
{
    partial class AgregarProductoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProductoForm));
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.APButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextDescription
            // 
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDescription.Location = new System.Drawing.Point(176, 104);
            this.TextDescription.Multiline = true;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(240, 20);
            this.TextDescription.TabIndex = 42;
            this.TextDescription.TextChanged += new System.EventHandler(this.TextDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Descripción";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Stock
            // 
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock.Location = new System.Drawing.Point(177, 335);
            this.Stock.Multiline = true;
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(240, 20);
            this.Stock.TabIndex = 40;
            this.Stock.TextChanged += new System.EventHandler(this.Stock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioVenta.Location = new System.Drawing.Point(177, 271);
            this.PrecioVenta.Multiline = true;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Size = new System.Drawing.Size(240, 20);
            this.PrecioVenta.TabIndex = 38;
            this.PrecioVenta.TextChanged += new System.EventHandler(this.PrecioVenta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Precio Venta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioCosto.Location = new System.Drawing.Point(176, 213);
            this.PrecioCosto.Multiline = true;
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.Size = new System.Drawing.Size(240, 20);
            this.PrecioCosto.TabIndex = 36;
            this.PrecioCosto.TextChanged += new System.EventHandler(this.PrecioCosto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Precio Costo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Agregar Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // APButton
            // 
            this.APButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.APButton.FlatAppearance.BorderSize = 0;
            this.APButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APButton.ForeColor = System.Drawing.Color.White;
            this.APButton.Location = new System.Drawing.Point(179, 399);
            this.APButton.Name = "APButton";
            this.APButton.Size = new System.Drawing.Size(239, 34);
            this.APButton.TabIndex = 49;
            this.APButton.Text = "Agregar Producto";
            this.APButton.UseVisualStyleBackColor = false;
            this.APButton.Click += new System.EventHandler(this.button1_Click_RegistrarProducto);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.APButton);
            this.panel1.Controls.Add(this.TextDescription);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Stock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PrecioVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PrecioCosto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 605);
            this.panel1.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Categoría";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgregarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 600);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductoForm";
            this.Load += new System.EventHandler(this.AgregarProductoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}