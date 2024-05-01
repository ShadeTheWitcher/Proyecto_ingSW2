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
                DateTime? menorFecha = db.Venta.Min(t => (DateTime?)t.fecha);
                //DTDesde.MinDate = menorFecha.Value;
            }
        }

        private void DataTracker_Load(object sender, EventArgs e)
        {
            this.Width = this.ClientSize.Width;
            this.Height = this.ClientSize.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(150, 50);
            label1.Text = "Línea 1\nLínea 2";
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
           
        }

       

        private void InitializeData(DateTime f_desde, DateTime f_hasta)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
        
}
