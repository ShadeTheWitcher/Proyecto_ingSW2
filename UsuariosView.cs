using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Models;

namespace Proyecto_Taller_AdminShop
{
    public partial class UsuariosView : UserControl
    {
        public UsuariosView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void InitializeDataGridView()
        {
            DG_Users.Rows.Clear();
            foreach (Usuario user in UserController.UsersAll())
            {
                DG_Users.Rows.Add(user.id_usuario,user.nombre, user.apellido,user.dni, user.telefono, user.correo, user.instagram);
            }
        }

        private void DG_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow SRow = DG_Users.SelectedRows[0];
            string delete_user = SRow.Cells["id"].Value.ToString();
            int id = int.Parse(delete_user);

            DialogResult result = MessageBox.Show("Desea Eliminar al usuario: ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserController.deleteUser(id);
                MessageBox.Show("Usuario Eliminado Correctamente!");
                this.InitializeDataGridView();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow SRow = DG_Users.SelectedRows[0];
            string delete_user = SRow.Cells["id"].Value.ToString();
            int id = int.Parse(delete_user);

            EditarUsuario editarUsuario = new EditarUsuario(id);
            editarUsuario.FormClosed += (s, args) => this.InitializeDataGridView();
            editarUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow SRow = DG_Users.SelectedRows[0];
            string edit_user = SRow.Cells["id"].Value.ToString();
            int id = int.Parse(edit_user);
            CambiarContraseña actualizarContraseña = new CambiarContraseña(id);
            actualizarContraseña.Show();
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {

        }
    }
}
