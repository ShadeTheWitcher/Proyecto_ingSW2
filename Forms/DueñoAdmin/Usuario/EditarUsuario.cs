using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Models;
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
    
    public partial class EditarUsuario : Form
    {
        private int idUsuario;
        private string pass;
        public EditarUsuario(int p_idUsuario)
        {
            idUsuario = p_idUsuario;
            InitializeComponent();
            initializeTextBox();
        }

        private void initializeTextBox()
        {
            Usuario user = Classes.UserController.OneUser(this.idUsuario);
            if (user != null)
            {
                pass = user.contraseña;
                TBNombre.Text = user.nombre;
                TBApellido.Text = user.apellido;
                TBEmail.Text = user.correo;
                TBInstagram.Text = user.instagram;
                TBtelefono.Text = user.telefono.ToString();
                TBDni.Text = user.dni.ToString();
                if(user.tipo_usuario == 2)
                {
                    CBrol.SelectedIndex = 0;
                }
                else
                {
                    CBrol.SelectedIndex = 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string email = TBEmail.Text;
            string dni = TBDni.Text;
            string instagram = TBInstagram.Text;
            string telefono = TBtelefono.Text;
            string rol = CBrol.SelectedItem?.ToString();

            // Validar campos y obtener valores parseados
            long dniParsed, telefonoParsed;
            string validacion = UserController.validarCampos(nombre, apellido, email, "111", dni, instagram, telefono, out dniParsed, out telefonoParsed, true);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método si hay errores de validación
            }

            // Llamar a EditarUsuario y manejar el resultado
            string resultado = UserController.EditarUsuario(this.idUsuario, nombre, apellido, email, dni, instagram, telefono, rol);

            if (resultado == "Usuario modificado correctamente!")
            {
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario si la edición fue exitosa
            }
            else
            {
                MessageBox.Show(resultado, "Error al Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBNombre.ToString(), 3, 50))
            {
                TBNombre.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBNombre.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBApellido.ToString(), 3, 50))
            {
                TBApellido.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBApellido.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBEmail.Text, 8, 40) && ValidationUser.ValidationEmail(TBEmail.Text))
            {
                TBEmail.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBEmail.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void TBtelefono_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBtelefono.ToString(), 10, 50))
            {
                TBtelefono.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBtelefono.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBDni.Text, 7, 9))
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
            if (ValidationUser.ValidationLengh(TBInstagram.ToString(), 3, 50))
            {
                TBInstagram.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBInstagram.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void AloneTxt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es una letra o una tecla de control (como Retroceso)
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
