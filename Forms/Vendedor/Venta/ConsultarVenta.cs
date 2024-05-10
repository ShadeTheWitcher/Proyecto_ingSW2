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

namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class ConsultarVenta : UserControl
    {
        public ConsultarVenta()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView(IEnumerable<Venta> ventas = null)
        {
            DG_Ventas_Vendedor.Rows.Clear();
            if (ventas == null)
            {
                ventas = SaleController.AllVentas();
            }
            foreach (Venta venta in ventas)
            {
                if (venta.id_cliente != null)
                {
                    DG_Ventas_Vendedor.Rows.Add(venta.id_venta, ClienteController.obtenerClientePorId(venta.id_cliente).nombre + ", " + ClienteController.obtenerClientePorId(venta.id_cliente).apellido, "$ " + venta.total, venta.fecha.ToString("dd-MM-yyyy"));
                }
                else
                {
                    DG_Ventas_Vendedor.Rows.Add(venta.id_venta, "--------", "$ " + venta.total, venta.fecha.ToString("dd-MM-yyyy"));

                }
            }
        }

        private void DG_Ventas_Vendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DTHasta.Value <= DateTime.Now && DTDesde.Value <= DTHasta.Value)
            {
                IEnumerable<Venta> date = SaleController.VentasDesdeHasta(DTDesde.Value, DTHasta.Value) ;
                DialogResult respuesta = MessageBox.Show("¿Quiere un PFD?", "Confirmación PDF", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    InformeVentas.InformeVentaspdf(date);
                }
                this.InitializeDataGridView(date);
            }
            else
            {
                MessageBox.Show("DTRangoFecha es posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void factura_Click(object sender, EventArgs e)
        {
            int id_venta = 0;

            int selectedRowIndex = DG_Ventas_Vendedor.SelectedRows[0].Index;
            id_venta = Convert.ToInt32(DG_Ventas_Vendedor.Rows[selectedRowIndex].Cells[0].Value);
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

        private void DTimer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
