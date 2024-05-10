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

namespace Proyecto_Taller_AdminShop
{
    public partial class ClientesView : UserControl
    {
        public ClientesView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Cliente Cliente in ClienteController.obtenerTodosClientes())
            {
                dataGridView1.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.dni, Cliente.domicilio, Cliente.telefono, Cliente.correo, Cliente.instagram);
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);


                EditarClienteForm editarClienteForm = new EditarClienteForm(idCliente);
                editarClienteForm.Show();
                editarClienteForm.FormClosed += (s, args) => this.InitializeDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                ClienteController.eliminarCliente(idCliente);
                this.InitializeDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientesView_Load(object sender, EventArgs e)
        {

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

            dataGridView1.Rows.Clear();

            foreach (Cliente Cliente in clientes)
            {
                dataGridView1.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.domicilio, Cliente.telefono, Cliente.correo);
            }
        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {
            if (TextDescription.Text == "")
            {
                var clientes = ClienteController.obtenerTodosClientes();

                dataGridView1.Rows.Clear();

                foreach (Cliente Cliente in clientes)
                {
                    dataGridView1.Rows.Add(Cliente.id_cliente, Cliente.nombre, Cliente.apellido, Cliente.dni, Cliente.domicilio, Cliente.telefono, Cliente.correo, Cliente.instagram);
                }
            }
        }
    }
}
