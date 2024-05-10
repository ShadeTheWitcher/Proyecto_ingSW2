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
    public partial class PanelPrincipal : Form
    {
        //PanelPrincipal prueba;
        public PanelPrincipal()
        {
            InitializeComponent();
            //prueba = this.
            this.WindowState = FormWindowState.Maximized;
            LoadDataTracker();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void IB_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            LoadDataTracker();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Height = this.ClientSize.Height;
            panel3.Width = this.ClientSize.Width;
        }

        private void RU_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            RegistrarUsuarioForm registrarUsuarioForm = new RegistrarUsuarioForm();
            panel3.Controls.Add(registrarUsuarioForm);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadDataTracker()
        {
            DataTracker dataTracker = new DataTracker();
            panel3.Controls.Add(dataTracker);
            UsuariosView dg = new UsuariosView();
            dg.InitializeDataGridView();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ConfirmarSalirForm confirmarSalirForm = new ConfirmarSalirForm();
            if (confirmarSalirForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UsuariosView usuariosView = new UsuariosView();
            panel3.Controls.Add(usuariosView);
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ConfiguraciónView configuraciónView = new ConfiguraciónView();
            panel3.Controls.Add(configuraciónView);
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
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
        //private void PanelPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        //{
           
            
        //    //Si hay otros formularios abiertos, muestra el formulario de inicio de sesión
        //    if (Application.OpenForms.Count == 1)
        //    {
        //          cerrarSesion();
        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }
            
        //}

       
    }
}
