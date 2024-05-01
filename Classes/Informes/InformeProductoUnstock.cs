using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop.Classes.Informes
{
    public class InformeProductosUnstock
    {
        public static void InfProductosUnstock(List<Producto> products = null)
        {
            if (products == null)
            {
                products = ProductoController.lowStockProducts();
            }
            SaveFileDialog pdf = new SaveFileDialog();
            pdf.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ReporteProductosUnstock_ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.reporteProductosUnstock.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ADMIN", AppState.userName);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", AppState.userDni.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            int total = 0;

            foreach (Producto product in products)
            {
                filas += "<tr>";
                filas += "<td>" + product.id_producto + "</td>";
                filas += "<td>" + product.descripcion + "</td>";
                filas += "<td>" + product.Categoria.descripcion +"</td>";
                filas += "<td>" +"$ "+ product.precio_venta + "</td>";
                filas += "<td>" + "$ " + product.precio_costo + "</td>";
                filas += "<td>" + product.stock + "</td>";
                filas += "</tr>";
                total ++;
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
    }
}
