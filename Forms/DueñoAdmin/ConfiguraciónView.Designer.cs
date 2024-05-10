namespace Proyecto_Taller_AdminShop
{
    partial class ConfiguraciónView
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
            this.BIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresar.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BIngresar.Location = new System.Drawing.Point(75, 112);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(305, 42);
            this.BIngresar.TabIndex = 16;
            this.BIngresar.Text = "Realizar Copia de Seguridad";
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Configuraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Guarda tus datos en una copia de seguridad, para recuperarlos si ocurre un imprev" +
    "isto.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Restaura los datos de la última copia de seguridad.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(75, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Restaurar base de datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBPassword
            // 
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(75, 319);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBPassword.Size = new System.Drawing.Size(339, 31);
            this.TBPassword.TabIndex = 22;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.TextChanged += new System.EventHandler(this.TBPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ingrese Clave de Confirmación";
            // 
            // ConfiguraciónView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BIngresar);
            this.Name = "ConfiguraciónView";
            this.Size = new System.Drawing.Size(944, 643);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label4;
    }
}
