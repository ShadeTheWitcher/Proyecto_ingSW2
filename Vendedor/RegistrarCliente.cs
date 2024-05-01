﻿using Proyecto_Taller_AdminShop.Classes;
using Proyecto_Taller_AdminShop.Classes.Informes;
using Proyecto_Taller_AdminShop.Classes.Models;
using Proyecto_Taller_AdminShop.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class RegistrarCliente : UserControl
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void BRCliente_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos del formulario
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

                ClienteController.addCliente(nombre, apellido, correo, telefonoParsed, instagram, domicilio, dniParsed);
                MessageBox.Show("Cliente agregado satisfactoriamente.", "Cliente Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch(Exception ex)
            {
                MessageBox.Show("Error al añadir cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeClientes.InformeClientesVendedor();
        }
    }
}
