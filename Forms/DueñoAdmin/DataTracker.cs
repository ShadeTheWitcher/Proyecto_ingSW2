using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Taller_AdminShop
{
    public partial class DataTracker : UserControl
    {
        public DataTracker()
        {
            InitializeComponent();
            InitializeGraf(DateTime.Now.AddMonths(-1), DateTime.Now);
            InitializeGrafClient(DateTime.Now.AddMonths(-1), DateTime.Now);
            InitializeGrafMejVendedores(DateTime.Now.AddMonths(-1), DateTime.Now);
            InitializeData(DateTime.Now.AddMonths(-1), DateTime.Now);

            using (var db = new Admin_shopEntities())
            {
                // Verificar si hay ventas en la base de datos
                if (db.Venta.Any())
                {
                    DateTime? menorFecha = db.Venta.Min(t => (DateTime?)t.fecha);
                    DTDesde.MinDate = menorFecha.Value;
                }
                else
                {
                    // Manejar el caso cuando no hay ventas
                    DTDesde.MinDate = DateTime.Now; // Puedes ajustar esta fecha según lo necesites
                }
            }
        }

        private void DataTracker_Load(object sender, EventArgs e)
        {
            this.Width = this.ClientSize.Width;
            this.Height = this.ClientSize.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Size = new Size(150, 50);
            //label1.Text = "Línea 1\nLínea 2";
        }

        private void InitializeGraf(DateTime f_desde, DateTime f_hasta)
        {
            ArrayList categorias = new ArrayList();
            ArrayList cantidades = new ArrayList();

            List<CategoriaConCantidadVendida> CCCV = SaleController.CategoriasConCantidadVendida(f_desde, f_hasta);
            foreach (CategoriaConCantidadVendida i in CCCV)
            {
                categorias.Add(i.categoria);
                cantidades.Add(i.cantidad);
            }
            chart1.Series[0].Points.DataBindXY(categorias, cantidades);
        }

        private void InitializeGrafClient(DateTime f_desde, DateTime f_hasta)
        {
            ArrayList names = new ArrayList();
            ArrayList total = new ArrayList();

            List<MejoresClientes> data = ClienteController.OchoMejoresClientes(f_desde, f_hasta);
            foreach (MejoresClientes a in data)
            {
                names.Add(a.nombre);
                total.Add(a.total);
            }
            chart2.Series[0].Points.DataBindXY(names, total);
        }

        private void InitializeGrafMejVendedores(DateTime f_desde, DateTime f_hasta)
        {
            ArrayList names = new ArrayList();
            ArrayList total = new ArrayList();
            List<List<float>> ventas = new List<List<float>>();
            List<List<DateTime>> fechas = new List<List<DateTime>>();
            ventas = CalcularVentasAcumuladas(ventas);
            List<MejoresVendedores> data = UserController.mejoresVendedores(f_desde, f_hasta);

            // Agregar datos a las listas
            for (int i = 0; i < data.Count; i++)
            {
                names.Add(data[i].Nombre);
                total.Add(data[i].TotalRecaudado);
                ventas.Add(data[i].Totales);
                fechas.Add(data[i].Fechas);
            }

            // Asegurarse de que chart3 tenga suficientes series
            while (chart3.Series.Count < 3)
            {
                chart3.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            }

            // Eliminar series sobrantes si hay menos de 3 vendedores
            while (chart3.Series.Count > data.Count)
            {
                chart3.Series.RemoveAt(chart3.Series.Count - 1);
            }

            // Actualizar nombres y puntos de las series según la cantidad de vendedores
            for (int i = 0; i < data.Count; i++)
            {
                chart3.Series[i].Name = $"{names[i]}_{i + 1}";
                chart3.Series[i].Points.DataBindXY(fechas[i], ventas[i]);
            }

            // Establecer formato de etiqueta del eje X
            chart3.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
        }

        static List<List<float>> CalcularVentasAcumuladas(List<List<float>> ventasDiarias)
        {
            List<List<float>> ventasAcumuladas = new List<List<float>>();

            foreach (var ventasDia in ventasDiarias)
            {
                float acumulado = 0;
                List<float> ventasDiaAcumuladas = new List<float>();

                foreach (var venta in ventasDia)
                {
                    acumulado += venta;
                    ventasDiaAcumuladas.Add(acumulado);
                }

                ventasAcumuladas.Add(ventasDiaAcumuladas);
            }

            return ventasAcumuladas;
        }


        private void InitializeData(DateTime f_desde, DateTime f_hasta)
        {
            LUsuarios.Text = "";
            LProductos.Text = "";
            LClientes.Text = "";
            LVentas.Text = "";
            LVendido.Text = "";
            LStock.Text = "";

            LUsuarios.Text = UserController.UsersAll().Count().ToString();
            LProductos.Text = ProductoController.ProductsAll().Count().ToString();
            LClientes.Text = ClienteController.obtenerTodosClientes().Count().ToString();
            LVentas.Text = SaleController.VentasDesdeAdmin(f_desde, f_hasta).Count().ToString();
            LVendido.Text = "$ " + SaleController.VentasDesdeAdmin(f_desde, f_hasta).Sum(a => a.total).ToString();
            LStock.Text = ProductoController.lowStockProducts().Count().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DTDesde.Value == DTHasta.Value)
            {
                MessageBox.Show("Fecha Hasta debe ser mayor a Fecha Desde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((DTHasta.Value <= DateTime.Now && DTDesde.Value <= DTHasta.Value))
            {
                using (var db = new Admin_shopEntities())
                {
                    var ventasEnRango = db.Venta.Any(v => v.fecha >= DTDesde.Value && v.fecha <= DTHasta.Value);

                    if (!ventasEnRango)
                    {
                        MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        InitializeGrafMejVendedores(DTDesde.Value, DTHasta.Value);
                        InitializeGrafClient(DTDesde.Value, DTHasta.Value);
                        InitializeGraf(DTDesde.Value, DTHasta.Value);
                        InitializeData(DTDesde.Value, DTHasta.Value);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fecha Fuera de Rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
        
}
