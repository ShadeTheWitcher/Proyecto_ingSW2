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
    public class InformeVentas
    {
        public static void InformeVentaspdf(IEnumerable<Venta> ventas = null, bool admin= false)
        {
            if (ventas == null)
            {
                ventas = SaleController.AllVentas();
            }
            SaveFileDialog pdf = new SaveFileDialog();
            pdf.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = string.Empty;
            if (admin)
            {
                PaginaHTML_Texto = Properties.Resources.ventasAdmin.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPO", "Administrador");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", AppState.userName);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", AppState.userDni.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                double total = 0;

                foreach (Venta sale in ventas)
                {
                    filas += "<tr>";
                    filas += "<td>" + sale.id_venta + "</td>";
                    if (sale.id_cliente != null)
                    {
                        filas += "<td>" + ClienteController.obtenerClientePorId(sale.id_cliente).nombre + ", " + ClienteController.obtenerClientePorId(sale.id_cliente).apellido + "</td>";
                    }
                    else
                    {
                        filas += "<td>" + "--------" + "</td>";
                    }
                    filas += "<td>" + sale.Usuario.nombre + ", " + sale.Usuario.apellido + "</td>";
                    filas += "<td>" + sale.fecha.ToString("dd/MM/yyyy") + "</td>";
                    filas += "<td>" + "$ " + sale.total + "</td>";
                    filas += "</tr>";
                    total += sale.total;
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            }
            else
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaVentas.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPO", "Vendedor");
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", AppState.userName);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", AppState.userDni.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                double total = 0;

                foreach (Venta sale in ventas)
                {
                    filas += "<tr>";
                    filas += "<td>" + sale.id_venta + "</td>";
                    if (sale.id_cliente != null)
                    {
                        filas += "<td>" + ClienteController.obtenerClientePorId(sale.id_cliente).nombre + ", " + ClienteController.obtenerClientePorId(sale.id_cliente).apellido + "</td>";
                    }
                    else
                    {
                        filas += "<td>" + "--------" + "</td>";
                    }
                    filas += "<td>" + sale.fecha.ToString("dd/MM/yyyy") + "</td>";
                    filas += "<td>" + "$ " + sale.total + "</td>";
                    filas += "</tr>";
                    total += sale.total;
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            }
            

            

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
    }
}
