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
                DGSale.Rows.RemoveAt(e.RowIndex);
                decimal sumaTotal = 0;
                foreach (DataGridViewRow row in DGSale.Rows)
                {
                    string valorCelda = row.Cells["Precio"].Value?.ToString().Replace("$ ", "");
                    if (decimal.TryParse(valorCelda, out decimal valorFila))
                    {
                        sumaTotal += valorFila;
                    }
                }
                label4.Text = $"Total: $ {sumaTotal}";// Elimina la fila
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox
            string textoBusqueda = productoNombreBuscador.Text;

            // Verifica si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Si está vacío, muestra un mensaje de error y sale del método.
                MessageBox.Show("Por favor, ingrese un nombre de producto para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si hay texto, llama a la función GetProductsByPartialName con el texto del TextBox como parámetro.
            var productos = ProductoController.obtenerProductosPorNombre(textoBusqueda);

            // Limpia las filas existentes antes de agregar nuevas
            DG_products_list.Rows.Clear();

            // Agrega los productos recuperados al DataGridView
            foreach (var producto in productos)
            {
                DG_products_list.Rows.Add(producto.id_producto, producto.descripcion, producto.Categoria.descripcion, "$ " + producto.precio_venta, producto.stock);
            }
        }

        private void cantidadInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(cantidadInput.Value);
            if (cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (DG_products_list.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = DG_products_list.CurrentRow.Index;
            string productoId = DG_products_list.Rows[rowIndex].Cells["ID"].Value.ToString();
            string nombreProducto = DG_products_list.Rows[rowIndex].Cells["descripcion"].Value.ToString();
            string precioProducto = DG_products_list.Rows[rowIndex].Cells["pVenta"].Value.ToString().Replace("$ ", "");
            decimal precio = decimal.Parse(precioProducto);
            int stock = Convert.ToInt32(DG_products_list.Rows[rowIndex].Cells["stock"].Value);

            if (cantidad > stock)
            {
                MessageBox.Show("Por favor, ingrese una cantidad que sea menor o igual al stock actual.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Calcula el precio total basado en la cantidad
            decimal precioTotal = precio * cantidad;

         
            int newIndex = DGSale.Rows.Add(productoId, nombreProducto, cantidad, "$ " + precioTotal);

            DataGridViewButtonCell btnEliminar = (DataGridViewButtonCell)DGSale.Rows[newIndex].Cells["Eliminar"];
            btnEliminar.Value = "Eliminar";
            btnEliminar.Style.Font = new Font("Quicksand", 10F, FontStyle.Bold); 
            btnEliminar.FlatStyle = FlatStyle.Flat;

            decimal sumaTotal = 0; 
            foreach (DataGridViewRow row in DGSale.Rows)
            {
                string valorCelda = row.Cells["Precio"].Value?.ToString().Replace("$ ", ""); 
                if (decimal.TryParse(valorCelda, out decimal valorFila))
                {
                    sumaTotal += valorFila;
                }
            }
            label4.Text = $"Total: $ {sumaTotal}";
           
            DG_products_list.ClearSelection();
            cantidadInput.Value = cantidadInput.Minimum;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Validar si hay productos en DGSale
            if (DGSale.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, agregue productos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear nueva venta
            Venta nuevaVenta = new Venta();
            nuevaVenta.fecha = DateTime.Now;
            nuevaVenta.total = float.Parse(label4.Text.Replace("Total: $ ", ""));
            nuevaVenta.id_usuario = AppState.idUser;
            if(idCliente != 0)
            {
                nuevaVenta.id_cliente = idCliente;
            }else
            {
                nuevaVenta.id_cliente = null;
            }
            nuevaVenta.estado = "1";
            db.Venta.Add(nuevaVenta);
            db.SaveChanges();

            foreach (DataGridViewRow row in DGSale.Rows)
            {
                Venta_detalle detalle = new Venta_detalle();

                detalle.id_venta = nuevaVenta.id_venta;
                detalle.id_producto = Convert.ToInt32(row.Cells["IdProducto"].Value); // Asegúrate de que el nombre de la columna coincida
                detalle.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                detalle.subtotal = float.Parse(row.Cells["Precio"].Value.ToString().Replace("$ ", ""));
                SaleController.controlStock(Convert.ToInt32(row.Cells["IdProducto"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value));
                db.Venta_detalle.Add(detalle);
            }
            db.SaveChanges(); // Guarda los detalles de venta en la base de datos
            InformeClientes.FacturaCliente(nuevaVenta.id_venta, idCliente);
            db.Database.BeginTransaction().Commit();
            MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            DGSale.Rows.Clear();
            label4.Text = "Total: $ 0";
            label6.Text = "Consumidor final";// Resetea el total
            Thread.Sleep(20);
            DG_products_list.Rows.Clear();
            foreach (var producto in ProductoController.ProductsAll())
            {   
                DG_products_list.Rows.Add(producto.id_producto, producto.descripcion, producto.Categoria.descripcion, "$ " + producto.precio_venta, producto.stock);
            }
            idCliente = 0;
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
