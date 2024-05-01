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
                TBDni.Text = user.telefono.ToString();
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
            int rol = 1;
            bool valid = ValidationUser.ValidationEmail(TBEmail)
                && ValidationUser.ValidationLengh(TBEmail,8,40)
                && ValidationUser.ValidationLengh(TBNombre, 3, 50)
                && ValidationUser.ValidationLengh(TBApellido, 3, 50)
                && ValidationUser.ValidationLengh(TBtelefono, 10, 50)
                && ValidationUser.ValidationLengh(TBDni, 7, 9)
                && ValidationUser.ValidationLengh(TBInstagram, 3, 50)
                && CBrol.SelectedIndex != -1;

            if (valid)
            {

                if (!ValidationUser.ValidateUniqueEmail(new Admin_shopEntities(), TBEmail.Text, true))
                {
     
                    if (CBrol.SelectedItem.ToString() == "Vendedor")
                    {
                        rol = 2;
                    }
                    else if (CBrol.SelectedItem.ToString() == "Administrador")
                    {
                        rol = 3;
                    }
                    string name = TBNombre.Text.Trim();
                    string mail = TBEmail.Text.Trim();
                    long dni = long.Parse(TBDni.Text);
                    string lastname = TBApellido.Text.Trim();
                    string ig = TBInstagram.Text.Trim();
                    long tf = long.Parse(TBtelefono.Text);

                    Classes.UserController.editUser(this.idUsuario, name, lastname, mail, tf, dni, ig, rol);
                    this.Close();
                    MessageBox.Show("Usuario Modificado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Correo ya registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBNombre, 3, 50))
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
            if (ValidationUser.ValidationLengh(TBApellido, 3, 50))
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
            if (ValidationUser.ValidationLengh(TBEmail, 8, 40) && ValidationUser.ValidationEmail(TBEmail))
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
            if (ValidationUser.ValidationLengh(TBtelefono, 10, 50))
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
            if (ValidationUser.ValidationLengh(TBDni, 7, 9))
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
            if (ValidationUser.ValidationLengh(TBInstagram, 3, 50))
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
