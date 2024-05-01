using Proyecto_Taller_AdminShop.Classes;
using System;
using System.Collections;
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
    public partial class EditarProductoForm : Form

    {
        public int idProducto;
        public EditarProductoForm(int idProducto)
        {
            InitializeComponent();
            InitComboBox();
            this.idProducto = idProducto;
            var productoParaActualizar = ProductoController.getOneProduct(idProducto);
            TextDescription.Text = productoParaActualizar.descripcion;
            comboBox1.SelectedValue = productoParaActualizar.Categoria.id_categoria;
            PrecioCosto.Text = productoParaActualizar.precio_costo.ToString();
            PrecioVenta.Text = productoParaActualizar.precio_venta.ToString();
            Stock.Text = productoParaActualizar.stock.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void APButton_Click(object sender, EventArgs e)
        {
            if (!ValidationProducts.IsCategorySelected(comboBox1))
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }


            if (!ValidationProducts.IsDescriptionValid(TextDescription.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal priceCost;
            if (!decimal.TryParse(PrecioCosto.Text, out priceCost) || !ValidationProducts.IsPriceValid(priceCost))
            {
                MessageBox.Show("Ingrese un precio de costo válido (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal priceSale;
            if (!decimal.TryParse(PrecioVenta.Text, out priceSale) || !ValidationProducts.IsPriceValid(priceSale))
            {
                MessageBox.Show("Ingrese un precio de venta válido (mayor a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stock;
            if (!int.TryParse(Stock.Text, out stock) || !ValidationProducts.IsStockValid(stock))
            {
                MessageBox.Show("El stock no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (comboBox1.SelectedItem is ComboBoxItem selectedItem)
                {
                    int categoriaId = selectedItem.Value;
                    // Haz algo con el valor...
                    float precioCosto = Convert.ToSingle(priceCost);
                    float precioVenta = Convert.ToSingle(priceSale);


                    ProductoController.editProduct(idProducto, categoriaId, TextDescription.Text, precioCosto, precioVenta, stock);

                    MessageBox.Show("Producto editado satisfactoriamente.", "¡Producto Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                // Manejar errores que puedan ocurrir durante la adición del producto
                MessageBox.Show("Error al añadir producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
