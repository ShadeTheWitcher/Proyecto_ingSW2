namespace Proyecto_Taller_AdminShop
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBInstagram = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BEditar = new System.Windows.Forms.Button();
            this.CBrol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.TBInstagram);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TBDni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BEditar);
            this.panel1.Controls.Add(this.CBrol);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TBtelefono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 724);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TBInstagram
            // 
            this.TBInstagram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBInstagram.Location = new System.Drawing.Point(126, 409);
            this.TBInstagram.Multiline = true;
            this.TBInstagram.Name = "TBInstagram";
            this.TBInstagram.Size = new System.Drawing.Size(363, 20);
            this.TBInstagram.TabIndex = 31;
            this.TBInstagram.TextChanged += new System.EventHandler(this.TBInstagram_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Instagram";
            // 
            // TBDni
            // 
            this.TBDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDni.Location = new System.Drawing.Point(125, 345);
            this.TBDni.Multiline = true;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(363, 20);
            this.TBDni.TabIndex = 29;
            this.TBDni.TextChanged += new System.EventHandler(this.TBDni_TextChanged);
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "D.N.I.";
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BEditar.FlatAppearance.BorderSize = 0;
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.Color.White;
            this.BEditar.Location = new System.Drawing.Point(123, 519);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(362, 34);
            this.BEditar.TabIndex = 27;
            this.BEditar.Text = "Editar Empleado";
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBrol
            // 
            this.CBrol.AllowDrop = true;
            this.CBrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBrol.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBrol.FormattingEnabled = true;
            this.CBrol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador"});
            this.CBrol.Location = new System.Drawing.Point(125, 469);
            this.CBrol.Name = "CBrol";
            this.CBrol.Size = new System.Drawing.Size(363, 26);
            this.CBrol.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Rol";
            // 
            // TBtelefono
            // 
            this.TBtelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBtelefono.Location = new System.Drawing.Point(125, 281);
            this.TBtelefono.Multiline = true;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(363, 20);
            this.TBtelefono.TabIndex = 24;
            this.TBtelefono.TextChanged += new System.EventHandler(this.TBtelefono_TextChanged);
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefono";
            // 
            // TBEmail
            // 
            this.TBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEmail.Location = new System.Drawing.Point(125, 224);
            this.TBEmail.Multiline = true;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(363, 20);
            this.TBEmail.TabIndex = 20;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // TBApellido
            // 
            this.TBApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBApellido.Location = new System.Drawing.Point(124, 166);
            this.TBApellido.Multiline = true;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(363, 20);
            this.TBApellido.TabIndex = 18;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AloneTxt);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido";
            // 
            // TBNombre
            // 
            this.TBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBNombre.Location = new System.Drawing.Point(124, 112);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(363, 20);
            this.TBNombre.TabIndex = 16;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AloneTxt);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Editar Empleado";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInstagram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.ComboBox CBrol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label2;
    }
}