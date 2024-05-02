namespace Proyecto_Taller_AdminShop.Vendedor
{
    partial class ConsultarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Ventas_Vendedor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.factura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ventas_Vendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // DTHasta
            // 
            this.DTHasta.CalendarFont = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTHasta.CalendarForeColor = System.Drawing.Color.White;
            this.DTHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.DTHasta.Checked = false;
            this.DTHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTHasta.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTHasta.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DTHasta.Location = new System.Drawing.Point(195, 120);
            this.DTHasta.Margin = new System.Windows.Forms.Padding(0);
            this.DTHasta.MaxDate = new System.DateTime(3030, 11, 6, 0, 0, 0, 0);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(106, 26);
            this.DTHasta.TabIndex = 36;
            this.DTHasta.Value = new System.DateTime(2023, 11, 6, 0, 0, 0, 0);
            this.DTHasta.ValueChanged += new System.EventHandler(this.DTimer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Consultar Ventas";
            // 
            // DG_Ventas_Vendedor
            // 
            this.DG_Ventas_Vendedor.AllowUserToAddRows = false;
            this.DG_Ventas_Vendedor.AllowUserToResizeColumns = false;
            this.DG_Ventas_Vendedor.AllowUserToResizeRows = false;
            this.DG_Ventas_Vendedor.BackgroundColor = System.Drawing.Color.White;
            this.DG_Ventas_Vendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Ventas_Vendedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Ventas_Vendedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Ventas_Vendedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Ventas_Vendedor.ColumnHeadersHeight = 30;
            this.DG_Ventas_Vendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Ventas_Vendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.precioTotal,
            this.fecha});
            this.DG_Ventas_Vendedor.EnableHeadersVisualStyles = false;
            this.DG_Ventas_Vendedor.Location = new System.Drawing.Point(80, 161);
            this.DG_Ventas_Vendedor.Name = "DG_Ventas_Vendedor";
            this.DG_Ventas_Vendedor.ReadOnly = true;
            this.DG_Ventas_Vendedor.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_Ventas_Vendedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Ventas_Vendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Ventas_Vendedor.Size = new System.Drawing.Size(736, 400);
            this.DG_Ventas_Vendedor.TabIndex = 17;
            this.DG_Ventas_Vendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Ventas_Vendedor_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 29;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            this.precioTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha de Venta";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(314, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Generar Reporte de Ventas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // factura
            // 
            this.factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factura.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.factura.Location = new System.Drawing.Point(619, 567);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(197, 37);
            this.factura.TabIndex = 35;
            this.factura.Text = "Ver Factura";
            this.factura.UseVisualStyleBackColor = false;
            this.factura.Click += new System.EventHandler(this.factura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Consultar Ventas desde hasta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DTDesde
            // 
            this.DTDesde.CalendarFont = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDesde.CalendarForeColor = System.Drawing.Color.White;
            this.DTDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.DTDesde.Checked = false;
            this.DTDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTDesde.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTDesde.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DTDesde.Location = new System.Drawing.Point(79, 120);
            this.DTDesde.Margin = new System.Windows.Forms.Padding(0);
            this.DTDesde.MaxDate = new System.DateTime(3030, 11, 6, 0, 0, 0, 0);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(106, 26);
            this.DTDesde.TabIndex = 38;
            this.DTDesde.Value = new System.DateTime(2023, 11, 6, 0, 0, 0, 0);
            // 
            // ConsultarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.DTDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTHasta);
            this.Controls.Add(this.factura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_Ventas_Vendedor);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarVenta";
            this.Size = new System.Drawing.Size(997, 813);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ventas_Vendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Ventas_Vendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private System.Windows.Forms.DateTimePicker DTDesde;
    }
}