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
    public partial class FIngresar : Form
    {
        public FIngresar()
        {
            InitializeComponent();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string sPass = Classes.Encrypt.GetSHA256(inputPassword.Text.Trim()); //incripta la password recibida por el input para compararla con la de la db
            using (Classes.Models.Admin_shopEntities db = new Classes.Models.Admin_shopEntities())
            {
                var lst = from d in db.Usuario
                          where d.correo == correo.Text
                          && d.contraseña == sPass
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
                else
                {
                    MessageBox.Show("Usuario no existe o contraseña equivocada!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
