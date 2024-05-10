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

        private void InitializeDataGrid(List<Producto> productosList=null)
        {   
           
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
           
        }
    }
}
