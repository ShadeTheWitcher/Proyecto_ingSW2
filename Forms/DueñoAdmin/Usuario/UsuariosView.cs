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
            if (DG_Users.SelectedRows.Count > 0)
            {
                DataGridViewRow SRow = DG_Users.SelectedRows[0];
                string delete_user = SRow.Cells["id"].Value.ToString();

                // Verificar si el valor de "id" no está vacío
                if (!string.IsNullOrEmpty(delete_user))
                {
                    int id = int.Parse(delete_user);

                    // Verificar si el id es diferente de 1
                    if (id != 1)
                    {
                        DialogResult result = MessageBox.Show("Desea Eliminar al usuario: ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UserController.deleteUser(id);
                            MessageBox.Show("Usuario Eliminado Correctamente!");
                            this.InitializeDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar al usuario Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el usuario porque el valor de 'id' está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios seleccionados para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DG_Users.SelectedRows.Count > 0)
            {
                DataGridViewRow SRow = DG_Users.SelectedRows[0];
                string edit_user = SRow.Cells["id"].Value.ToString();

                // Verificar si el valor de "id" no está vacío
                if (!string.IsNullOrEmpty(edit_user))
                {
                    int id = int.Parse(edit_user);

                    // Verificar si el id es diferente de 1
                    if (id != 1)
                    {
                        EditarUsuario editarUsuario = new EditarUsuario(id);
                        editarUsuario.FormClosed += (s, args) => this.InitializeDataGridView();
                        editarUsuario.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se puede editar al usuario Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede editar el usuario porque el valor de 'id' está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios seleccionados para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DG_Users.SelectedRows.Count > 0)
            {
                DataGridViewRow SRow = DG_Users.SelectedRows[0];
                string edit_user = SRow.Cells["id"].Value.ToString();

                // Verificar si el valor de "id" no está vacío
                if (!string.IsNullOrEmpty(edit_user))
                {
                    int id = int.Parse(edit_user);
                    CambiarContraseña actualizarContraseña = new CambiarContraseña(id);
                    actualizarContraseña.Show();
                }
                else
                {
                    MessageBox.Show("No se puede editar la contraseña porque el valor de 'id' está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios seleccionados para editar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {

        }
    }
}
