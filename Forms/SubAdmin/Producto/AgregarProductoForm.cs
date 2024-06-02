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
    public partial class AgregarProductoForm : Form
    {
        public AgregarProductoForm()
        {
            InitializeComponent();
            InitComboBox();

        }

        private void InitComboBox()
        {
            var items = new List<ComboBoxItem>
        {
            new ComboBoxItem("Golosinas", 1),
            new ComboBoxItem("Bebidas", 2),
            new ComboBoxItem("Snacks", 3),
            new ComboBoxItem("Cigarrillos", 4),
            new ComboBoxItem("Helados y Postres", 5),
            new ComboBoxItem("Panadería", 6),
            new ComboBoxItem("Primera Necesidad", 7)
        };

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                int value = selectedItem.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void PrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_RegistrarProducto(object sender, EventArgs e)
        {
            ProductoController productoController = new ProductoController();

            try
            {
                if (productoController.RegistrarProducto(
                    TextDescription.Text, 
                    comboBox1.SelectedItem, 
                    PrecioCosto.Text, 
                    PrecioVenta.Text, 
                    Stock.Text))
                    {
                        MessageBox.Show("Producto añadido satisfactoriamente.", "Producto Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            
        

        private bool ValidarCamposProducto()
        {
            if (!ValidationProducts.IsCategorySelected(comboBox1))
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return false;
            }

            if (!ValidationProducts.IsDescriptionValid(TextDescription.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(PrecioCosto.Text, out decimal priceCost) || !ValidationProducts.IsPriceValid(priceCost))
            {
                MessageBox.Show("Ingrese un precio de costo válido (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(PrecioVenta.Text, out decimal priceSale) || !ValidationProducts.IsPriceValid(priceSale))
            {
                MessageBox.Show("Ingrese un precio de venta válido (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Stock.Text, out int stock) || !ValidationProducts.IsStockValid(stock))
            {
                MessageBox.Show("El stock no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }






        private void AgregarProductoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
