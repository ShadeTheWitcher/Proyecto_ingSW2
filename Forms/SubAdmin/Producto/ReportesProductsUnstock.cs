using Proyecto_Taller_AdminShop.Classes.Models;
using Proyecto_Taller_AdminShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_AdminShop.Classes.Informes;

namespace Proyecto_Taller_AdminShop
{
    public partial class ReportesProductsUnstock : UserControl
    {
        public ReportesProductsUnstock()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DG_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGrid(List<Producto> productosList = null)
        {
            if (productosList == null)
            {
                productosList = ProductoController.lowStockProducts();
            }

            DG_ProductsStock.Rows.Clear();
            foreach (Producto Product in productosList)
            {
                int row = DG_ProductsStock.Rows.Add(Product.id_producto, Product.descripcion, Product.Categoria.descripcion, "$ " + Product.precio_venta, "$ " + Product.precio_costo, Product.stock);
                if (Product.stock == 0)
                {
                    DG_ProductsStock.Rows[row].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D60303");
                }
            }
        }
        private void BReporte_Click(object sender, EventArgs e)
        {
            List<Producto> date = ProductoController.lowStockProducts();
            DialogResult respuesta = MessageBox.Show("¿Quiere un PFD?", "Confirmación PDF", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                InformeProductosUnstock.InfProductosUnstock(date);
            }
            this.InitializeDataGrid(date);
        }
    }
}
