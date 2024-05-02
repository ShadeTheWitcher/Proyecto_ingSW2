using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Models;

namespace Proyecto_Taller_AdminShop
{
    public partial class ProductosView : UserControl
    {
        
        public ProductosView()
        {
            InitializeComponent();
            initDataGrid();
            InitComboBox();
        }

        public void initDataGrid(int idCategoria = 0)
        {   
            DG_Products.Rows.Clear();
            IEnumerable<Producto> productos;
            if (idCategoria == 0)
            {
                productos = ProductoController.ProductsAll();
            } else
            {
                productos = ProductoController.obtenerProductosPorCategoria(idCategoria);
            }

            foreach (Producto Product in productos)
            {
                DG_Products.Rows.Add(Product.id_producto, Product.descripcion, Product.Categoria.descripcion , "$ " + Product.precio_venta, "$ " + Product.precio_costo, Product.stock);
            }
        }

        private void InitComboBox()
        {
            var items = new List<ComboBoxItem>
        {
            new ComboBoxItem("Todos los productos", 0),
            new ComboBoxItem("Golosinas", 1),
            new ComboBoxItem("Bebidas", 2),
            new ComboBoxItem("Snacks", 3),
            new ComboBoxItem("Cigarrillos", 4),
            new ComboBoxItem("Helados y Postres", 5),
            new ComboBoxItem("Panadería", 6),
            new ComboBoxItem("Primera Necesidad", 7)
        };

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (DG_Products.SelectedRows.Count > 0)
            {
                int selectedRowIndex = DG_Products.SelectedRows[0].Index;
                int idProducto = Convert.ToInt32(DG_Products.Rows[selectedRowIndex].Cells[0].Value);


                EditarProductoForm editarProductoForm = new EditarProductoForm(idProducto);  
                editarProductoForm.Show();
                editarProductoForm.FormClosed += (s, args) => this.initDataGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (DG_Products.SelectedRows.Count > 0)
            {
                int selectedRowIndex = DG_Products.SelectedRows[0].Index;
                int idProducto = Convert.ToInt32(DG_Products.Rows[selectedRowIndex].Cells[0].Value);
                ProductoController.deleteProduct(idProducto);
                this.initDataGrid();
            } else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DG_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textoBusqueda = productoNombreBuscador.Text;

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un nombre de producto para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productos = ProductoController.obtenerProductosPorNombre(textoBusqueda);

            DG_Products.Rows.Clear();

            foreach (var Product in productos)
            {
                DG_Products.Rows.Add(Product.id_producto, Product.descripcion, Product.Categoria.descripcion, "$ " + Product.precio_venta, "$ " + Product.precio_costo, Product.stock);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = comboBox1.SelectedItem as ComboBoxItem;
                if (selectedItem != null)
                {
                    int selectedValue = selectedItem.Value;
                    initDataGrid(selectedValue); // Actualiza el DataGridView basado en la categoría seleccionada
                }
            }
        }

        private void productoNombreBuscador_TextChanged(object sender, EventArgs e)
        {
            if (productoNombreBuscador.Text == "")
            {
                var productos = ProductoController.ProductsAll();

                DG_Products.Rows.Clear();

                foreach (Producto Product in productos)
                {
                    DG_Products.Rows.Add(Product.id_producto, Product.descripcion, Product.Categoria.descripcion, "$ " + Product.precio_venta, "$ " + Product.precio_costo, Product.stock);
                }
            }
        }



        private void button1_Click_AgregarProducto(object sender, EventArgs e)
        {
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm();
            agregarProductoForm.Show();
            agregarProductoForm.FormClosed += (s, args) => this.initDataGrid();
        }
    }
}
