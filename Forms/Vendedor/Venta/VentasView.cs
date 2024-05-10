using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Informes;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    public partial class VentasView : UserControl
    {
        public VentasView()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigureDataGridView(List<Venta> sales = null)
        {

           
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void factura_Click(object sender, EventArgs e)
        {

        }

        private void DGVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReporteVenta_Click(object sender, EventArgs e)
        {
            
        }
    }
}
