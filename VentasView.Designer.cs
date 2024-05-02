namespace Proyecto_Taller_AdminShop
{
    partial class VentasView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.Button();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.ReporteVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventas";
            // 
            // DGVentas
            // 
            this.DGVentas.AllowUserToAddRows = false;
            this.DGVentas.AllowUserToResizeColumns = false;
            this.DGVentas.AllowUserToResizeRows = false;
            this.DGVentas.BackgroundColor = System.Drawing.Color.White;
            this.DGVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVentas.ColumnHeadersHeight = 30;
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.precioTotal,
            this.fecha});
            this.DGVentas.EnableHeadersVisualStyles = false;
            this.DGVentas.Location = new System.Drawing.Point(91, 125);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.ReadOnly = true;
            this.DGVentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVentas.Size = new System.Drawing.Size(736, 400);
            this.DGVentas.TabIndex = 19;
            this.DGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Nombre Vendedor";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioTotal.HeaderText = "Fecha Venta";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Total";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // factura
            // 
            this.factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factura.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.factura.Location = new System.Drawing.Point(664, 546);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(163, 37);
            this.factura.TabIndex = 36;
            this.factura.Text = "Ver Factura";
            this.factura.UseVisualStyleBackColor = false;
            this.factura.Click += new System.EventHandler(this.factura_Click);
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
            this.DTHasta.Location = new System.Drawing.Point(209, 88);
            this.DTHasta.Margin = new System.Windows.Forms.Padding(0);
            this.DTHasta.MaxDate = new System.DateTime(3030, 11, 6, 0, 0, 0, 0);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(106, 26);
            this.DTHasta.TabIndex = 39;
            this.DTHasta.Value = new System.DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // ReporteVenta
            // 
            this.ReporteVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ReporteVenta.FlatAppearance.BorderSize = 0;
            this.ReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteVenta.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteVenta.ForeColor = System.Drawing.Color.White;
            this.ReporteVenta.Location = new System.Drawing.Point(331, 88);
            this.ReporteVenta.Name = "ReporteVenta";
            this.ReporteVenta.Size = new System.Drawing.Size(204, 26);
            this.ReporteVenta.TabIndex = 38;
            this.ReporteVenta.Text = "Generar Reporte de Ventas";
            this.ReporteVenta.UseVisualStyleBackColor = false;
            this.ReporteVenta.Click += new System.EventHandler(this.ReporteVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Consultar Ventas desde hasta:";
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
            this.DTDesde.Location = new System.Drawing.Point(90, 88);
            this.DTDesde.Margin = new System.Windows.Forms.Padding(0);
            this.DTDesde.MaxDate = new System.DateTime(3030, 11, 6, 0, 0, 0, 0);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(106, 26);
            this.DTDesde.TabIndex = 42;
            this.DTDesde.Value = new System.DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // VentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.DTDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTHasta);
            this.Controls.Add(this.ReporteVenta);
            this.Controls.Add(this.factura);
            this.Controls.Add(this.DGVentas);
            this.Controls.Add(this.label1);
            this.Name = "VentasView";
            this.Size = new System.Drawing.Size(1179, 726);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Button factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private System.Windows.Forms.Button ReporteVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTDesde;
    }
}
