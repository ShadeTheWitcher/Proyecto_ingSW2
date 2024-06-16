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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Taller_AdminShop
{
    public partial class FIngresar : Form
    {
        public FIngresar()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (correo.Focused)
                {
                    // Mover el foco a textBox2
                    inputPassword.Focus();
                    return true; // Indicar que hemos manejado la tecla Tab
                }
                else if (inputPassword.Focused)
                {
                    // Mover el foco a textBox1
                    correo.Focus();
                    return true; // Indicar que hemos manejado la tecla Tab
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string sPass = Classes.Encrypt.GetSHA256(inputPassword.Text.Trim()); //incripta la password recibida por el input para compararla con la de la db
            using (Classes.Models.Admin_shopEntities db = new Classes.Models.Admin_shopEntities())
            {
                var lst = from d in db.Usuario
                          where d.correo == correo.Text
                          && d.contrasena == sPass
                          select d;

                if (lst.Any())
                {
                    var userFound = lst.First();
                    this.Hide();

                    correo.Text = "";
                    inputPassword.Text = "";
                    sPass = "";

                    switch (userFound.tipo_usuario)
                    {
                        case 1:
                            PanelPrincipal FrmP = new PanelPrincipal();
                            FrmP.FormClosed += (s, args) => this.Show();
                            FrmP.Show();
                            break;
                        case 3:
                            PanelAdmin FrmA = new PanelAdmin();
                            FrmA.FormClosed += (s, args) => this.Show();
                            FrmA.Show();
                            break;
                        case 2:
                            Vendedor.PanelVendedor FrmV = new Vendedor.PanelVendedor();
                            FrmV.FormClosed += (s, args) => this.Show();
                            FrmV.Show();
                            break;
                    }
                    AppState.idUser = userFound.id_usuario;
                    AppState.userName = userFound.nombre;
                    AppState.userDni = userFound.dni;
                }
                else if (string.IsNullOrWhiteSpace(correo.Text) && string.IsNullOrWhiteSpace(inputPassword.Text))
                {
                    MessageBox.Show("Ingrese Correo y Contraseña para ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Correo no existe o contraseña equivocada!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
 
    }
}
