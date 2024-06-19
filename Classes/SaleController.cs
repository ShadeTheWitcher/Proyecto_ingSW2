using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Proyecto_Taller_AdminShop.Classes.Informes;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

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
            btnEliminar.Style.Font = new System.Drawing.Font("Quicksand", 10F, FontStyle.Bold);
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

            generarFactura(nuevaVenta.id_venta, idCliente);
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

        public static void generarFactura(int id_venta, int? id_cliente = 0)
        {
            Cliente cliente = null;
            if (id_cliente != 0)
            {
                cliente = ClienteController.obtenerClientePorId(id_cliente);
            }

            SaveFileDialog pdf = new SaveFileDialog();
            pdf.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Factura.ToString();

            if (cliente == null)
            {
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", "Consumidor Final");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "---------------");
            }
            else
            {
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", cliente.nombre + ", " + cliente.apellido);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", cliente.dni.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FACTURA", id_venta.ToString());

            string filas = string.Empty;
            double total = 0;




            var detallesVenta = ClienteController.detallesVenta(id_venta);

            if (detallesVenta != null && detallesVenta.Any())
            {
                foreach (Venta_detalle ventDetail in detallesVenta)
                {
                    var producto = ProductoController.getOneProduct(ventDetail.id_producto);

                    if (producto != null)
                    {
                        filas += "<tr>";
                        filas += "<td>" + ventDetail.cantidad.ToString() + "</td>";
                        filas += "<td>" + producto.descripcion + "</td>";
                        filas += "<td>" + "$ " + (ventDetail.subtotal / ventDetail.cantidad).ToString() + "</td>";
                        filas += "<td>" + "$ " + ventDetail.subtotal.ToString() + "</td>";
                        filas += "</tr>";
                        total += ventDetail.subtotal;
                    }
                    else
                    {
                        filas += "<tr>";
                        filas += "<td colspan='4'>Producto no encontrado</td>";
                        filas += "</tr>";
                    }
                }
            }
            else
            {

                filas = "<tr><td colspan='4'>No hay detalles de venta</td></tr>";
            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            if (pdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(pdf.FileName, FileMode.Create))
                {
                    // Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    // Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    // img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    // Agregar el contenido HTML al PDF
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
                System.Diagnostics.Process.Start(pdf.FileName);
            }
        }

    }
}
