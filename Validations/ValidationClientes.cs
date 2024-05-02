using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Validations
{
    internal class ValidationClientes
    {
        public static bool IsNombreValid(string nombre)
        {
            // Asegura que el nombre no sea null, vacío o solamente espacios en blanco
            return !string.IsNullOrWhiteSpace(nombre);
        }

        public static bool IsApellidoValid(string apellido)
        {
            // Asegura que el apellido no sea null, vacío o solamente espacios en blanco
            return !string.IsNullOrWhiteSpace(apellido);
        }

        public static bool IsCorreoValid(string correo)
        {
            // Asegura que el correo no sea null, vacío y que coincida con un formato de correo electrónico válido
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            return Regex.IsMatch(correo, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
        }

        public static bool IsTelefonoValid(string telefono)
        {
            // Asegura que el teléfono sea numérico y no esté vacío
            long result;
            return !string.IsNullOrWhiteSpace(telefono) && long.TryParse(telefono, out result);
        }

        public static bool IsInstagramValid(string instagram)
        {
            // Asegura que el usuario de Instagram no esté vacío
            return !string.IsNullOrWhiteSpace(instagram);
        }
    }
}
