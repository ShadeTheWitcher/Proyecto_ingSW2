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

namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class PanelVendedor : Form

    {
        Color colorSeleccionado = Color.FromArgb(184, 197, 220); // gris claro
        Color colorNoSeleccionado = Color.FromArgb(141, 153, 174); // blanco, o cualquier otro color que sea tu color por defecto

        // Asegúrate de tener una referencia a todos los botones
        Button[] botones;
        public PanelVendedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            RegistrarCliente registrarCliente = new RegistrarCliente();
            panelPrincipal.Controls.Add(registrarCliente);
            RC.BackColor = colorSeleccionado;
            botones = new Button[] { CV, RC, RV };
        }

        private void CambiarColorBoton(Button botonSeleccionado)
        {
            foreach (Button boton in botones)
            {
                if (boton == botonSeleccionado)
                    boton.BackColor = colorSeleccionado;
                else
                    boton.BackColor = colorNoSeleccionado;
            }
        }

        private void IB_Click(object sender, EventArgs e)
        {
            // Tu código original
            panelPrincipal.Controls.Clear();
            RegistrarVenta registrarVenta = new RegistrarVenta();
            panelPrincipal.Controls.Add(registrarVenta);

            // Cambiar colores de botones
            CambiarColorBoton((Button)sender);
        }

        private void RU_Click(object sender, EventArgs e)
        {
            // Tu código original
            panelPrincipal.Controls.Clear();
            ConsultarVenta consultarVenta = new ConsultarVenta();
            panelPrincipal.Controls.Add(consultarVenta);

            // Cambiar colores de botones
            CambiarColorBoton((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tu código original
            panelPrincipal.Controls.Clear();
            RegistrarCliente registrarCliente = new RegistrarCliente();
            panelPrincipal.Controls.Add(registrarCliente);

            // Cambiar colores de botones
            CambiarColorBoton((Button)sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelVendedor_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            ConfirmarSalirForm confirmarSalirForm = new ConfirmarSalirForm();
            if (confirmarSalirForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            panelPrincipal.Height = this.ClientSize.Height;
            panelPrincipal.Width = this.ClientSize.Width;
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
