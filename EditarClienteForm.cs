using Proyecto_Taller_AdminShop.Classes.Models;
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
using Proyecto_Taller_AdminShop.Validations;

namespace Proyecto_Taller_AdminShop
{

    public partial class EditarClienteForm : Form
    {
        public int idCliente;
        public EditarClienteForm(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            var clienteParaActualizar = ClienteController.obtenerClientePorId(idCliente);
            RCTNombre.Text = clienteParaActualizar.nombre;
            RCTApellido.Text = clienteParaActualizar.apellido;
            RCTCorreo.Text = clienteParaActualizar.correo;
            RCTTelefono.Text = clienteParaActualizar.telefono.ToString();
            RCTDni.Text = clienteParaActualizar.dni.ToString();
            RCTInstagram.Text = clienteParaActualizar.instagram;
            RCTDomicilio.Text = clienteParaActualizar.domicilio;
        }

        private void BRCliente_Click(object sender, EventArgs e)
        {
            string nombre = RCTNombre.Text;
            string apellido = RCTApellido.Text;
            string correo = RCTCorreo.Text;
            string telefono = RCTTelefono.Text;
            string instagram = RCTInstagram.Text;
            string domicilio = RCTDomicilio.Text;
            string dni = RCTDni.Text;

            // Validar los campos utilizando los métodos de validación
            bool nombreValido = ValidationClientes.IsNombreValid(nombre);
            bool apellidoValido = ValidationClientes.IsApellidoValid(apellido);
            bool correoValido = ValidationClientes.IsCorreoValid(correo);
            bool telefonoValido = ValidationClientes.IsTelefonoValid(telefono);
            bool instagramValido = ValidationClientes.IsInstagramValid(instagram);
            bool domicilioValido = ValidationClientes.IsNombreValid(domicilio);

            if (!domicilioValido)
            {
                MessageBox.Show("Por favor, ingrese un domicilio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!nombreValido)
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!apellidoValido)
            {
                MessageBox.Show("Por favor, ingrese un apellido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!correoValido)
            {
                MessageBox.Show("Por favor, ingrese un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!telefonoValido)
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!instagramValido)
            {
                MessageBox.Show("Por favor, ingrese un usuario de Instagram válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                long telefonoParsed;
                if (!long.TryParse(telefono, out telefonoParsed))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener el proceso
                }

                long dniParsed;
                if (!long.TryParse(dni, out dniParsed))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido mogolico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener el proceso
                }

                ClienteController.editarCliente(idCliente, nombre, apellido, correo, telefonoParsed, instagram, domicilio, dniParsed);
                MessageBox.Show("Cliente actualizado satisfactoriamente.", "Cliente editado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
