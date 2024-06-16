using iTextSharp.tool.xml.parser;
using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Informes;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class RegistrarVenta : UserControl
    {
        private static Admin_shopEntities db = new Admin_shopEntities();
        private static int idCliente = 0;
        private SaleController saleController = new SaleController();
        public RegistrarVenta()

        {
            InitializeComponent();
            InitializeDataGridView();
            InitComboBox();
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Esto asegura que hayamos hecho clic en una fila y no en el encabezado

            // Si se ha hecho clic en la columna "Eliminar"
            if (DGSale.Columns[e.ColumnIndex].Name == "eliminar")
            {
                // Utiliza el método del controlador para manejar la eliminación y actualización
                saleController.EliminarFilaYActualizarTotal(DGSale, e.RowIndex, label4);
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
        private void InitializeDataGridView(int idCategoria = 0) // valor predeterminado cambiado a 0
        {

            DG_products_list.Rows.Clear(); // Limpia las filas existentes antes de agregar nuevas

            IEnumerable<Producto> productos;

            if (idCategoria == 0)
            {
                productos = ProductoController.ProductsAll();
            }
            else
            {
                productos = ProductoController.obtenerProductosPorCategoria(idCategoria);
            }

            foreach (Producto Product in productos)
            {
                DG_products_list.Rows.Add(Product.id_producto, Product.descripcion,Product.Categoria.descripcion, "$ " + Product.precio_venta, Product.stock);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //golosinas

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = comboBox1.SelectedItem as ComboBoxItem;
                if (selectedItem != null)
                {
                    int selectedValue = selectedItem.Value;
                    InitializeDataGridView(selectedValue); // Actualiza el DataGridView basado en la categoría seleccionada
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productoNombreBuscador_TextChanged(object sender, EventArgs e)
        {
            if (productoNombreBuscador.Text == "")
            {
                var productos = ProductoController.ProductsAll();

                DG_products_list.Rows.Clear();

                foreach (Producto Product in productos)
                {
                    DG_products_list.Rows.Add(Product.id_producto, Product.descripcion, Product.Categoria.descripcion, "$ " + Product.precio_venta, Product.stock);
                }
            }
        }

        //Realiza la busqueda de un producto
        private void button3_Click(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox
            string textoBusqueda = productoNombreBuscador.Text;

            // Si hay texto, llama a la función obtenerProductosPorNombre con el texto del TextBox como parámetro.
            var productos = ProductoController.obtenerProductosPorNombre(textoBusqueda);

            // Verifica si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Si está vacío, muestra un mensaje de error y sale del método.
                MessageBox.Show("Por favor, ingrese un nombre de producto para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Si existe el producto ejecuta esto sino lo otro
            else if (productos != null && productos.Any())
            {
                // Limpia las filas existentes antes de agregar nuevas
                DG_products_list.Rows.Clear();

                // Agrega los productos recuperados al DataGridView
                foreach (var producto in productos)
                {
                    DG_products_list.Rows.Add(producto.id_producto, producto.descripcion, producto.Categoria.descripcion, "$ " + producto.precio_venta, producto.stock);
                }
            }
            else
            {
                MessageBox.Show("No existe el producto buscado. Por favor reintentelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productoNombreBuscador.Text = "";
            }

        }

        private void cantidadInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            saleController.AgregarProducto(DG_products_list, DGSale, label4, cantidadInput);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saleController.RegistrarVenta(DGSale, DG_products_list, label4, label6, idCliente);

        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            BuscadorClientes buscadorClientes = new BuscadorClientes();

            buscadorClientes.ClienteSeleccionado += (clienteSeleccionado) =>
            {
                label6.Text = clienteSeleccionado.nombre + " " + clienteSeleccionado.apellido;
                idCliente = clienteSeleccionado.id_cliente;
            };

            buscadorClientes.Show();
        }
    }
}
