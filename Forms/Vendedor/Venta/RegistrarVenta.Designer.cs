namespace Proyecto_Taller_AdminShop.Vendedor
{
    partial class RegistrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadInput = new System.Windows.Forms.NumericUpDown();
            this.agregarButton = new System.Windows.Forms.Button();
            this.DGSale = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DG_products_list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoNombreBuscador = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_products_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nueva Venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(215, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ordenar por Categoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // cantidadInput
            // 
            this.cantidadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadInput.Location = new System.Drawing.Point(129, 466);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(137, 26);
            this.cantidadInput.TabIndex = 22;
            this.cantidadInput.ValueChanged += new System.EventHandler(this.cantidadInput_ValueChanged);
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.ForeColor = System.Drawing.Color.White;
            this.agregarButton.Location = new System.Drawing.Point(166, 507);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(239, 34);
            this.agregarButton.TabIndex = 23;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // DGSale
            // 
            this.DGSale.AllowUserToAddRows = false;
            this.DGSale.AllowUserToResizeColumns = false;
            this.DGSale.AllowUserToResizeRows = false;
            this.DGSale.BackgroundColor = System.Drawing.Color.White;
            this.DGSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGSale.ColumnHeadersHeight = 30;
            this.DGSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.nombre,
            this.cantidad,
            this.Precio,
            this.eliminar});
            this.DGSale.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGSale.EnableHeadersVisualStyles = false;
            this.DGSale.Location = new System.Drawing.Point(632, 123);
            this.DGSale.Name = "DGSale";
            this.DGSale.ReadOnly = true;
            this.DGSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGSale.RowHeadersVisible = false;
            this.DGSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DGSale.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSale.Size = new System.Drawing.Size(530, 298);
            this.DGSale.TabIndex = 0;
            this.DGSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.Frozen = true;
            this.IdProducto.HeaderText = "ProductoId";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Width = 157;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad.Width = 158;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio Total";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 157;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Frozen = true;
            this.eliminar.HeaderText = "Acciones";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total: $ 0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(705, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 34);
            this.button2.TabIndex = 26;
            this.button2.Text = "Confirmar Venta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DG_products_list
            // 
            this.DG_products_list.AllowUserToAddRows = false;
            this.DG_products_list.AllowUserToResizeColumns = false;
            this.DG_products_list.AllowUserToResizeRows = false;
            this.DG_products_list.BackgroundColor = System.Drawing.Color.White;
            this.DG_products_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_products_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_products_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_products_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_products_list.ColumnHeadersHeight = 30;
            this.DG_products_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_products_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.dataGridViewTextBoxColumn2,
            this.pVenta,
            this.stock});
            this.DG_products_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DG_products_list.EnableHeadersVisualStyles = false;
            this.DG_products_list.Location = new System.Drawing.Point(26, 124);
            this.DG_products_list.Name = "DG_products_list";
            this.DG_products_list.ReadOnly = true;
            this.DG_products_list.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_products_list.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_products_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_products_list.Size = new System.Drawing.Size(567, 298);
            this.DG_products_list.TabIndex = 28;
            this.DG_products_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 30;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Nombre";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pVenta
            // 
            this.pVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pVenta.HeaderText = "Precio Venta";
            this.pVenta.Name = "pVenta";
            this.pVenta.ReadOnly = true;
            this.pVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stock.Width = 55;
            // 
            // productoNombreBuscador
            // 
            this.productoNombreBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productoNombreBuscador.Location = new System.Drawing.Point(215, 65);
            this.productoNombreBuscador.Multiline = true;
            this.productoNombreBuscador.Name = "productoNombreBuscador";
            this.productoNombreBuscador.Size = new System.Drawing.Size(240, 20);
            this.productoNombreBuscador.TabIndex = 29;
            this.productoNombreBuscador.TextChanged += new System.EventHandler(this.productoNombreBuscador_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(29, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 28);
            this.button3.TabIndex = 30;
            this.button3.Text = "Buscar Producto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientButton.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.ForeColor = System.Drawing.Color.White;
            this.clientButton.Location = new System.Drawing.Point(982, 17);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(180, 28);
            this.clientButton.TabIndex = 31;
            this.clientButton.Text = "Buscar Cliente";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "consumidor final";
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.productoNombreBuscador);
            this.Controls.Add(this.DG_products_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGSale);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cantidadInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarVenta";
            this.Size = new System.Drawing.Size(1332, 612);
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_products_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cantidadInput;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.DataGridView DGSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DG_products_list;
        private System.Windows.Forms.TextBox productoNombreBuscador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
