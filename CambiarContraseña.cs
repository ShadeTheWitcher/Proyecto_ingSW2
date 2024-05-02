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
    public partial class CambiarContraseña : Form
    {
        public int idUsuario;
        private string userEmail;
        public CambiarContraseña(int pIdUsuario)
        {
            InitializeComponent();
            this.idUsuario = pIdUsuario;
            var usuarioActualizar = UserController.OneUser(idUsuario);
            userEmail = usuarioActualizar.correo;
            nombreUsuario.Text = usuarioActualizar.apellido.ToString() + " " + usuarioActualizar.nombre.ToString();
            
        }

        private void BRUser_Click(object sender, EventArgs e)
        {
            // Text boxes con las contraseñas introducidas por el usuario
            string currentPasswordInput = TBContraseña.Text.Trim();
            string newPassword = textBox1.Text.Trim();
            string confirmNewPassword = textBox2.Text.Trim();

            // Convertir la contraseña actual introducida a SHA256 para la comprobación
            string hashedCurrentPasswordInput = Classes.Encrypt.GetSHA256(currentPasswordInput);

            using (Classes.Models.Admin_shopEntities db = new Classes.Models.Admin_shopEntities())
            {
                // Obtener el usuario que está actualizando la contraseña
                var user = db.Usuario.FirstOrDefault(u => u.correo == userEmail); // Asumiendo que tienes una manera de obtener el correo del usuario actual

                // Comprobar que la contraseña actual es la correcta
                if (user != null && user.contraseña == hashedCurrentPasswordInput)
                {
                    // Verificar que las nuevas contraseñas coinciden
                    if (newPassword == confirmNewPassword)
                    {
                        // Convertir la nueva contraseña a SHA256
                        string hashedNewPassword = Classes.Encrypt.GetSHA256(newPassword);

                        // Actualizar la contraseña en la base de datos
                        user.contraseña = hashedNewPassword;
                        db.SaveChanges(); // Guardar los cambios en la base de datos

                        MessageBox.Show("Contraseña actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Las nuevas contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña actual es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
