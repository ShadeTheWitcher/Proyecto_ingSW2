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
        public PanelPrincipal()
        {
            InitializeComponent();
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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
