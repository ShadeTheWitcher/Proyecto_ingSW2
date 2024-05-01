using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    internal class ValidationProducts
    {
        public static bool IsCategorySelected(ComboBox comboBox)
        {
            return comboBox.SelectedItem != null;
        }

        public static bool IsDescriptionValid(string description)
        {
            // Asegura que la descripción no sea null, vacía o solamente espacios en blanco
            return !string.IsNullOrWhiteSpace(description);
        }

        public static bool IsPriceValid(decimal price)
        {
            // Asegura que el precio sea mayor que 0
            return price > 0;
        }

        public static bool IsStockValid(int stock)
        {
            // Asegura que el stock no sea negativo
            return stock >= 0;
        }
    }
}

