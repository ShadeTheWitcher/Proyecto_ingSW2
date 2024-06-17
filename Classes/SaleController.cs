using Proyecto_Taller_AdminShop.Classes.Informes;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop.Classes
{
    public class SaleController
    {
        private static Admin_shopEntities db = new Admin_shopEntities();
        public static IEnumerable<Venta> AllVentas() {
            IEnumerable<Venta> ventas = from d in db.Venta
                         where d.estado == "1"
                         where d.id_usuario == AppState.idUser
                         select d;
            return ventas;
        }

        public static IEnumerable<Venta> AllVentasAdmin()
        {
            IEnumerable<Venta> ventas = from d in db.Venta
                                        join p in db.Usuario on d.id_usuario equals p.id_usuario
                                        where d.estado == "1"
                                        select d;
            return ventas;
        }

        public static Venta oneVenta(int id)
        {
            return (from d in db.Venta where d.id_venta == id select d).First();
        }


        public static IEnumerable<Venta> VentasDesdeHasta(DateTime f_desde, DateTime f_hasta)
        {
            db = new Admin_shopEntities();
            DateTime fechaDesde = f_desde.AddDays(-1);
            IEnumerable<Venta> venta = from d in db.Venta
                                       where d.estado == "1"
                                       where d.id_usuario == AppState.idUser
                                       where d.fecha >= fechaDesde
                                       where d.fecha <= f_hasta
                                       select d;
            return venta;
            
        }

        public static IEnumerable<Venta> VentasDesdeAdmin(DateTime f_desde, DateTime f_hasta)
        {
            db = new Admin_shopEntities();
            DateTime fechaDesde = f_desde.AddDays(-1);
            IEnumerable<Venta> venta = from d in db.Venta
                                       where d.estado == "1"
                                       where d.fecha >= fechaDesde
                                       where d.fecha <= f_hasta
                                       select d;
            return venta;
        }



        public static List<CategoriaConCantidadVendida> CategoriasConCantidadVendida(DateTime f_desde, DateTime f_hasta)
        {
            using (Admin_shopEntities db = new Admin_shopEntities())
            {
                DateTime fechadesde = f_desde.AddDays(-1);
                var ventasDesdeHasta = from v in db.Venta
                                       where v.fecha >= fechadesde
                                       where v.fecha <= f_hasta
                                       select v;
                var categoriasConCantidad = from vd in db.Venta_detalle
                                            where ventasDesdeHasta.Select(v => v.id_venta).Contains(vd.id_venta)
                                            join p in db.Producto on vd.id_producto equals p.id_producto
                                            join c in db.Categoria on p.id_categoria equals c.id_categoria
                                            group vd by c.descripcion into g
                                            select new CategoriaConCantidadVendida
                                            {  
                                                categoria = g.Key,
                                                cantidad = g.Sum(item => item.cantidad)
                                            };

                return categoriasConCantidad.ToList();
            }
        }

        public void AgregarProducto(DataGridView productsList, DataGridView saleList, Label totalLabel, NumericUpDown cantidadInput)
        {
            int cantidad = Convert.ToInt32(cantidadInput.Value);
            if (cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productsList.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = productsList.CurrentRow.Index;
            string productoId = productsList.Rows[rowIndex].Cells["ID"].Value.ToString();
            string nombreProducto = productsList.Rows[rowIndex].Cells["descripcion"].Value.ToString();
            string precioProducto = productsList.Rows[rowIndex].Cells["pVenta"].Value.ToString().Replace("$ ", "");
            decimal precio = decimal.Parse(precioProducto);
            int stock = Convert.ToInt32(productsList.Rows[rowIndex].Cells["stock"].Value);

            if (cantidad > stock)
            {
                MessageBox.Show("Por favor, ingrese una cantidad que sea menor o igual al stock actual.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //decimal precioTotal = precio * cantidad;
            decimal precioTotal = calcularPrecioTotal(precio, cantidad);

            int newIndex = saleList.Rows.Add(productoId, nombreProducto, cantidad, "$ " + precioTotal);

            DataGridViewButtonCell btnEliminar = (DataGridViewButtonCell)saleList.Rows[newIndex].Cells["Eliminar"];
            btnEliminar.Value = "Eliminar";
            btnEliminar.Style.Font = new Font("Quicksand", 10F, FontStyle.Bold);
            btnEliminar.FlatStyle = FlatStyle.Flat;

            ActualizarTotal(saleList, totalLabel);

            productsList.ClearSelection();
            cantidadInput.Value = cantidadInput.Minimum;
        }

        private decimal calcularPrecioTotal(decimal precio, int cantidad)
        {
            return precio * cantidad;
        }

        // Método para actualizar el total
        private void ActualizarTotal(DataGridView saleList, Label totalLabel)
        {
            decimal sumaTotal = 0;
            foreach (DataGridViewRow row in saleList.Rows)
            {
                string valorCelda = row.Cells["Precio"].Value?.ToString().Replace("$ ", "");
                if (decimal.TryParse(valorCelda, out decimal valorFila))
                {
                    sumaTotal += valorFila;
                }
            }
            totalLabel.Text = $"Total: $ {sumaTotal}";
        }



        // Método para eliminar una fila y actualizar el total
        public void EliminarFilaYActualizarTotal(DataGridView dataGridView, int rowIndex, Label totalLabel)
        {
            dataGridView.Rows.RemoveAt(rowIndex);
            ActualizarTotal(dataGridView, totalLabel);
        }

        public void RegistrarVenta(DataGridView saleList, DataGridView productsList, Label totalLabel, Label clienteLabel, int idCliente)
        {
            
            if (saleList.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, agregue productos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Venta nuevaVenta = new Venta
            {
                fecha = DateTime.Now,
                total = float.Parse(totalLabel.Text.Replace("Total: $ ", "")),
                id_usuario = AppState.idUser,
                id_cliente = idCliente != 0 ? (int?)idCliente : null,
                estado = "1"
            };

            db.Venta.Add(nuevaVenta);
            db.SaveChanges();

            foreach (DataGridViewRow row in saleList.Rows)
            {
                Venta_detalle detalle = new Venta_detalle
                {
                    id_venta = nuevaVenta.id_venta,
                    id_producto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    subtotal = float.Parse(row.Cells["Precio"].Value.ToString().Replace("$ ", ""))
                };

                ProductoController.controlStock(Convert.ToInt32(row.Cells["IdProducto"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value));
                db.Venta_detalle.Add(detalle);
            }
            db.SaveChanges();

            InformeClientes.FacturaCliente(nuevaVenta.id_venta, idCliente);
            db.Database.BeginTransaction().Commit();
            MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            saleList.Rows.Clear();
            totalLabel.Text = "Total: $ 0";
            clienteLabel.Text = "Consumidor final";

            Thread.Sleep(20);
            productsList.Rows.Clear();
            foreach (var producto in ProductoController.ProductsAll())
            {
                productsList.Rows.Add(producto.id_producto, producto.descripcion, producto.Categoria.descripcion, "$ " + producto.precio_venta, producto.stock);
            }
        }


    }
}
