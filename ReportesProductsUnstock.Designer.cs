namespace Proyecto_Taller_AdminShop
{
    partial class ReportesProductsUnstock
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
            this.DG_ProductsStock = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ProductsStock
            // 
            this.DG_ProductsStock.AllowUserToAddRows = false;
            this.DG_ProductsStock.AllowUserToResizeColumns = false;
            this.DG_ProductsStock.AllowUserToResizeRows = false;
            this.DG_ProductsStock.BackgroundColor = System.Drawing.Color.White;
            this.DG_ProductsStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ProductsStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_ProductsStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ProductsStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ProductsStock.ColumnHeadersHeight = 30;
            this.DG_ProductsStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_ProductsStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.Categoria,
            this.pVenta,
            this.PrecioCosto,
            this.stock});
            this.DG_ProductsStock.EnableHeadersVisualStyles = false;
            this.DG_ProductsStock.Location = new System.Drawing.Point(52, 74);
            this.DG_ProductsStock.Name = "DG_ProductsStock";
            this.DG_ProductsStock.ReadOnly = true;
            this.DG_ProductsStock.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_ProductsStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ProductsStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_ProductsStock.Size = new System.Drawing.Size(844, 400);
            this.DG_ProductsStock.TabIndex = 4;
            this.DG_ProductsStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Products_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 30;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // pVenta
            // 
            this.pVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pVenta.HeaderText = "Precio Venta";
            this.pVenta.Name = "pVenta";
            this.pVenta.ReadOnly = true;
            this.pVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioCosto.HeaderText = "Precio Costo";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            this.PrecioCosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stock.Width = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Productos Próximos a Agotarse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BReporte
            // 
            this.BReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BReporte.Enabled = false;
            this.BReporte.FlatAppearance.BorderSize = 0;
            this.BReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReporte.ForeColor = System.Drawing.Color.White;
            this.BReporte.Location = new System.Drawing.Point(522, 491);
            this.BReporte.Name = "BReporte";
            this.BReporte.Size = new System.Drawing.Size(374, 36);
            this.BReporte.TabIndex = 35;
            this.BReporte.Text = "Generar Reporte Productos Próximos a Agotarse";
            this.BReporte.UseVisualStyleBackColor = false;
            this.BReporte.Click += new System.EventHandler(this.BReporte_Click);
            // 
            // ReportesProductsUnstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BReporte);
            this.Controls.Add(this.DG_ProductsStock);
            this.Controls.Add(this.label1);
            this.Name = "ReportesProductsUnstock";
            this.Size = new System.Drawing.Size(950, 664);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductsStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_ProductsStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BReporte;
    }
}
