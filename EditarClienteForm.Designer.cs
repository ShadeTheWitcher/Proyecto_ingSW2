namespace Proyecto_Taller_AdminShop
{
    partial class EditarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarClienteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RCTDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RCTDomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BRCliente = new System.Windows.Forms.Button();
            this.RCTInstagram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RCTTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RCTCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RCTApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RCTNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.RCTDni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.RCTDomicilio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BRCliente);
            this.panel1.Controls.Add(this.RCTInstagram);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RCTTelefono);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RCTCorreo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RCTApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RCTNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 609);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RCTDni
            // 
            this.RCTDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTDni.Location = new System.Drawing.Point(187, 454);
            this.RCTDni.Multiline = true;
            this.RCTDni.Name = "RCTDni";
            this.RCTDni.Size = new System.Drawing.Size(406, 20);
            this.RCTDni.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "DNI";
            // 
            // RCTDomicilio
            // 
            this.RCTDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTDomicilio.Location = new System.Drawing.Point(188, 404);
            this.RCTDomicilio.Multiline = true;
            this.RCTDomicilio.Name = "RCTDomicilio";
            this.RCTDomicilio.Size = new System.Drawing.Size(406, 20);
            this.RCTDomicilio.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Domicilio";
            // 
            // BRCliente
            // 
            this.BRCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BRCliente.FlatAppearance.BorderSize = 0;
            this.BRCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRCliente.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRCliente.ForeColor = System.Drawing.Color.White;
            this.BRCliente.Location = new System.Drawing.Point(185, 487);
            this.BRCliente.Name = "BRCliente";
            this.BRCliente.Size = new System.Drawing.Size(406, 44);
            this.BRCliente.TabIndex = 44;
            this.BRCliente.Text = "Editar Cliente";
            this.BRCliente.UseVisualStyleBackColor = false;
            this.BRCliente.Click += new System.EventHandler(this.BRCliente_Click);
            // 
            // RCTInstagram
            // 
            this.RCTInstagram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTInstagram.Location = new System.Drawing.Point(187, 353);
            this.RCTInstagram.Multiline = true;
            this.RCTInstagram.Name = "RCTInstagram";
            this.RCTInstagram.Size = new System.Drawing.Size(406, 20);
            this.RCTInstagram.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Instagram";
            // 
            // RCTTelefono
            // 
            this.RCTTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTTelefono.Location = new System.Drawing.Point(187, 293);
            this.RCTTelefono.Multiline = true;
            this.RCTTelefono.Name = "RCTTelefono";
            this.RCTTelefono.Size = new System.Drawing.Size(406, 20);
            this.RCTTelefono.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefono";
            // 
            // RCTCorreo
            // 
            this.RCTCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTCorreo.Location = new System.Drawing.Point(187, 229);
            this.RCTCorreo.Multiline = true;
            this.RCTCorreo.Name = "RCTCorreo";
            this.RCTCorreo.Size = new System.Drawing.Size(406, 20);
            this.RCTCorreo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Correo";
            // 
            // RCTApellido
            // 
            this.RCTApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTApellido.Location = new System.Drawing.Point(186, 171);
            this.RCTApellido.Multiline = true;
            this.RCTApellido.Name = "RCTApellido";
            this.RCTApellido.Size = new System.Drawing.Size(407, 20);
            this.RCTApellido.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Apellido";
            // 
            // RCTNombre
            // 
            this.RCTNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCTNombre.Location = new System.Drawing.Point(186, 117);
            this.RCTNombre.Multiline = true;
            this.RCTNombre.Name = "RCTNombre";
            this.RCTNombre.Size = new System.Drawing.Size(407, 20);
            this.RCTNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 40);
            this.label9.TabIndex = 33;
            this.label9.Text = "Editar Cliente";
            // 
            // EditarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarClienteForm";
            this.Text = "EditarClienteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RCTDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RCTDomicilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BRCliente;
        private System.Windows.Forms.TextBox RCTInstagram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RCTTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RCTCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RCTApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RCTNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}