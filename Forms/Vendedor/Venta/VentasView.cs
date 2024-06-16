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

       

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        

        private void DGVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void factura_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = DGVentas.SelectedRows[0].Index;
            int id_venta = Convert.ToInt32(DGVentas.Rows[selectedRowIndex].Cells[0].Value);
            var idCliente = SaleController.oneVenta(id_venta).id_cliente;

            if (idCliente == null)
            {
                InformeClientes.FacturaCliente(id_venta);
            }
            else
            {
                InformeClientes.FacturaCliente(id_venta, idCliente);
            }
        }
        private void ReporteVenta_Click(object sender, EventArgs e)
        {
            if (DTDesde.Value <= DateTime.Now && DTDesde.Value <= DTDesde.Value)
            {
                IEnumerable<Venta> date = SaleController.VentasDesdeAdmin(DTDesde.Value, DTHasta.Value);
                DialogResult respuesta = MessageBox.Show("¿Quiere un PFD?", "Confirmación PDF", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    InformeVentas.InformeVentaspdf(date);
                }
                this.ConfigureDataGridView(date.ToList());
            }
            else
            {
                MessageBox.Show("DTRangoFecha es posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView(List<Venta> sales = null)
        {

            DGVentas.Rows.Clear();
            if (sales == null)
            {
                sales = SaleController.AllVentasAdmin().ToList();
            }
            foreach (Venta Venta in sales)
            {
                DGVentas.Rows.Add(Venta.id_venta, Venta.Usuario.nombre + ' ' + Venta.Usuario.apellido, Venta.fecha.ToString("dd-MM-yyyy"), "$ " + Venta.total);
            }
        }
    }
}
