using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Proyecto_Taller_AdminShop.Classes;

namespace Proyecto_Taller_AdminShop
{
    public partial class RegistrarUsuarioForm : UserControl
    {
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBNombre.Text, 3, 50))
            {
                TBNombre.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBNombre.ForeColor = System.Drawing.Color.Red;
            }
        }
        
        private void TBNombreKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es una letra o una tecla de control (como Retroceso)
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es una letra o una tecla de control (como Retroceso)
            }
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationEmail(TBEmail.Text))
            {
                // El correo es válido, no hagas nada
                TBEmail.ForeColor = System.Drawing.Color.Black; // Restaurar el color del texto
            }
            else
            {
                // El correo no es válido, cambia el color del texto o muestra un mensaje de error
                TBEmail.ForeColor = System.Drawing.Color.Red; // Cambia el color del texto a rojo
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número o una tecla de control (como Retroceso)
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número o una tecla de control (como Retroceso)
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBApellido.Text, 3, 50))
            {
                TBApellido.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBApellido.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBContraseña_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBContraseña.Text, 6, 20))
            {
                TBContraseña.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBContraseña.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBTelefono.Text, 3, 50))
            {
                TBTelefono.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBTelefono.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBDni.Text, 3, 50))
            {
                TBDni.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBDni.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBInstagram_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBInstagram.Text, 3, 50))
            {
                TBInstagram.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBInstagram.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBContraseña_TextChanged_1(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBContraseña.Text, 6, 20))
            {
                TBContraseña.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBContraseña.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void RegistrarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void BRUser_Click_RegistrarEmpleado(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string email = TBEmail.Text;
            string contraseña = TBContraseña.Text;
            string dni = TBDni.Text;
            string instagram = TBInstagram.Text;
            string telefono = TBTelefono.Text;
            string rol = CBRol.SelectedItem?.ToString();

            string resultado = UserController.RegistrarUsuario(nombre, apellido, email, contraseña, dni, instagram, telefono, rol);

            if (resultado == "Usuario creado correctamente!")
            {
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TBNombre.Clear();
                TBApellido.Clear();
                TBContraseña.Clear();
                CBRol.SelectedIndex = -1;
                TBEmail.Clear();
                TBDni.Clear();
                TBInstagram.Clear();
                TBTelefono.Clear();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

