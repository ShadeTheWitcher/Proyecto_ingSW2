namespace Proyecto_Taller_AdminShop
{
    partial class ProductosView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Products = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.productoNombreBuscador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos";
            // 
            // DG_Products
            // 
            this.DG_Products.AllowUserToAddRows = false;
            this.DG_Products.AllowUserToResizeColumns = false;
            this.DG_Products.AllowUserToResizeRows = false;
            this.DG_Products.BackgroundColor = System.Drawing.Color.White;
            this.DG_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_Products.ColumnHeadersHeight = 30;
            this.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.Categoria,
            this.pVenta,
            this.PrecioCosto,
            this.stock});
            this.DG_Products.EnableHeadersVisualStyles = false;
            this.DG_Products.Location = new System.Drawing.Point(93, 144);
            this.DG_Products.Name = "DG_Products";
            this.DG_Products.ReadOnly = true;
            this.DG_Products.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_Products.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Products.Size = new System.Drawing.Size(844, 400);
            this.DG_Products.TabIndex = 0;
            this.DG_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Products_CellContentClick);
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
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BAgregar.Location = new System.Drawing.Point(774, 556);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(163, 37);
            this.BAgregar.TabIndex = 17;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.button1_Click_AgregarProducto);
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BEditar.Location = new System.Drawing.Point(605, 556);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(163, 37);
            this.BEditar.TabIndex = 16;
            this.BEditar.Text = "Editar";
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BEliminar.Location = new System.Drawing.Point(436, 556);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(163, 37);
            this.BEliminar.TabIndex = 18;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(93, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 31);
            this.button3.TabIndex = 34;
            this.button3.Text = "Buscar Producto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productoNombreBuscador
            // 
            this.productoNombreBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productoNombreBuscador.Location = new System.Drawing.Point(279, 66);
            this.productoNombreBuscador.Multiline = true;
            this.productoNombreBuscador.Name = "productoNombreBuscador";
            this.productoNombreBuscador.Size = new System.Drawing.Size(240, 25);
            this.productoNombreBuscador.TabIndex = 33;
            this.productoNombreBuscador.TextChanged += new System.EventHandler(this.productoNombreBuscador_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ordenar por Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Golosinas",
            "Bebidas",
            "Snacks",
            "Cigarrillos",
            "Helados y Postres",
            "Panadería",
            "Primera Necesidad"});
            this.comboBox1.Location = new System.Drawing.Point(279, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 23);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "Sin stock";
            this.button1.UseVisualStyleBackColor = false;
            
            // 
            // ProductosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.productoNombreBuscador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.DG_Products);
            this.Controls.Add(this.label1);
            this.Name = "ProductosView";
            this.Size = new System.Drawing.Size(969, 896);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Products;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox productoNombreBuscador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}
