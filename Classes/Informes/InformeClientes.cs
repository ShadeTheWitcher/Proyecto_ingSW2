using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Windows.Forms;
using Proyecto_Taller_AdminShop.Classes.Models;

namespace Proyecto_Taller_AdminShop.Classes.Informes
{
    public class InformeClientes
    {
        public static void InformeClientesVendedor() {
            SaveFileDialog pdf = new SaveFileDialog();
            pdf.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", AppState.userName);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", AppState.userDni.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;

            foreach (Cliente client in ClienteController.obtenerClientes())
            {
                filas += "<tr>";
                filas += "<td>" + client.id_cliente + "</td>";
                filas += "<td>" + client.nombre +" , "+ client.apellido+ "</td>";
                filas += "<td>" + client.apellido + "</td>";
                filas += "<td>" + client.telefono + "</td>";
                filas += "<td>" + client.dni + "</td>";
                filas += "</tr>";
                total += 1;
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            if (pdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(pdf.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
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
        //
        public static void FacturaCliente(int id_venta, int? id_cliente = 0)
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

        //
        //public static void FacturaCliente(int id_venta, int? id_cliente = 0)
        //{
        //    Cliente cliente = null;
        //    if(id_cliente != 0)
        //    {
        //        cliente = ClienteController.obtenerClientePorId(id_cliente);
        //    }
            
        //    SaveFileDialog pdf = new SaveFileDialog();
        //    pdf.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

        //    string PaginaHTML_Texto = Properties.Resources.Factura.ToString();
        //    if (cliente == null)
        //    {
        //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", "Consumidor Final");
        //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "---------------");
        //    }
        //    else
        //    {
        //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", cliente.nombre + ", "+ cliente.apellido);
        //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", cliente.dni.ToString());
        //    }
        //    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
        //    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FACTURA", id_venta.ToString());

        //    string filas = string.Empty;
        //    double total = 0;

        //    foreach (Venta_detalle ventDetail in ClienteController.detallesVenta(id_venta))
        //    {
        //        filas += "<tr>";
        //        filas += "<td>" + ventDetail.cantidad.ToString() + "</td>";
        //        filas += "<td>" + ProductoController.getOneProduct(ventDetail.id_producto).descripcion + "</td>";
        //        filas += "<td>" + "$ " + (ventDetail.subtotal / ventDetail.cantidad).ToString() + "</td>";
        //        filas += "<td>" +"$ "+ ventDetail.subtotal + "</td>";
        //        filas += "</tr>";
        //        total += ventDetail.subtotal;
        //    }
        //    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
        //    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

        //    if (pdf.ShowDialog() == DialogResult.OK)
        //    {
        //        using (FileStream stream = new FileStream(pdf.FileName, FileMode.Create))
        //        {
        //            //Creamos un nuevo documento y lo definimos como PDF
        //            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

        //            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
        //            pdfDoc.Open();
        //            pdfDoc.Add(new Phrase(""));

        //            //Agregamos la imagen del banner al documento
        //            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
        //            img.ScaleToFit(60, 60);
        //            img.Alignment = iTextSharp.text.Image.UNDERLYING;

        //            //img.SetAbsolutePosition(10,100);
        //            img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
        //            pdfDoc.Add(img);


        //            //pdfDoc.Add(new Phrase("Hola Mundo"));
        //            using (StringReader sr = new StringReader(PaginaHTML_Texto))
        //            {
        //                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
        //            }

        //            pdfDoc.Close();
        //            stream.Close();
        //        }
        //        System.Diagnostics.Process.Start(pdf.FileName);
        //    }

        //}
    }
}
