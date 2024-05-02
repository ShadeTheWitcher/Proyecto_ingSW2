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

namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class BuscadorClientes : Form
    {
        public delegate void ClienteSeleccionadoHandler(Cliente clienteSeleccionado);
        public event ClienteSeleccionadoHandler ClienteSeleccionado;
        public BuscadorClientes()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void BuscadorClientes_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            ClientesTable.Rows.Clear();
            foreach (Cliente Cliente in ClienteController.obtenerTodosClientes())
            {
                ClientesTable.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.domicilio, Cliente.telefono, Cliente.correo);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClientesTable.SelectedRows.Count > 0)
            {
                var filaSeleccionada = ClientesTable.SelectedRows[0];
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["id_cliente"].Value);

                Cliente cliente = ClienteController.obtenerClientePorId(idCliente); // Asegúrate de tener este método en tu controlador.

                // Disparar el evento con el cliente seleccionado
                ClienteSeleccionado?.Invoke(cliente);

                MessageBox.Show("Cliente seleccionado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {
            if(TextDescription.Text == "")
            {
                var clientes = ClienteController.obtenerClientes();

                ClientesTable.Rows.Clear();

                foreach (Cliente Cliente in clientes)
                {
                    ClientesTable.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.domicilio, Cliente.telefono, Cliente.correo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clienteTextBusqueda = TextDescription.Text;
            if (string.IsNullOrWhiteSpace(clienteTextBusqueda))
            {
                // Si está vacío, muestra un mensaje de error y sale del método.
                MessageBox.Show("Por favor, ingrese un nombre de producto para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clientes = ClienteController.getClientesBySearch(clienteTextBusqueda);

            ClientesTable.Rows.Clear();

            foreach (Cliente Cliente in clientes)
            {
                ClientesTable.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.domicilio, Cliente.telefono, Cliente.correo);
            }

        }
    }
}
