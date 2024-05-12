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

namespace Proyecto_Taller_AdminShop
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ProductosView productos = new ProductosView();
            productos.initDataGrid();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

            LoadVentasView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Height = this.ClientSize.Height;
            panel3.Width = this.ClientSize.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ClientesView clientesView = new ClientesView();
            panel3.Controls.Add(clientesView);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ConfirmarSalirForm confirmarSalirForm = new ConfirmarSalirForm();
            if (confirmarSalirForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RU_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            LoadVentasView();
        }

        private void LoadVentasView()
        {
            VentasView ventasView = new VentasView();
            panel3.Controls.Add(ventasView);
        }

        private void IB_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ProductosView productosView = new ProductosView();
            panel3.Controls.Add(productosView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ReportesProductsUnstock UC = new ReportesProductsUnstock();
            panel3.Controls.Add(UC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void cerrarSesion()
        {
            ConfirmarCerrarSesionForm confirmarCierreForm = new ConfirmarCerrarSesionForm();
            if (confirmarCierreForm.ShowDialog() == DialogResult.Yes)
            {
                // Limpiar los datos de la sesión
                AppState.idUser = 0;
                AppState.userName = "";
                AppState.userDni = 0;


                this.Close();

            }

        }
    }
}
