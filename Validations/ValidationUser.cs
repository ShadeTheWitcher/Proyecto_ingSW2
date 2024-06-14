using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    internal class ValidationUser
    {
        public static bool ValidationLengh(string text, int l_min, int l_max)
        {
            return (l_min <= text.Length && text.Length <= l_max);
        }

        public static bool ValidationEmail(string text)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);

            return text.Length >= 7 && regex.IsMatch(text);
        }

        public static bool ValidateUniqueEmail(Classes.Models.Admin_shopEntities dbContext, string correo, int? id = null)
        {
            if (id.HasValue)
            {
                // Excluye el usuario actual de la verificación
                return !dbContext.Usuario.Any(u => u.correo == correo && u.id_usuario != id.Value);
            }
            // Para nuevo usuario, verifica si ya existe el correo
            return dbContext.Usuario.Any(u => u.correo == correo);
        }

        public static bool ValidateUniqueDNI(Classes.Models.Admin_shopEntities dbContext, string dni, int? id = null)
        {
            if (!long.TryParse(dni, out long dniNumber))
            {
                // Si no se puede convertir a long, retorna falso o maneja el error según tu lógica.
                return false;
            }

            if (id.HasValue)
            {
                // Excluye el usuario actual de la verificación
                return !dbContext.Usuario.Any(u => u.dni == dniNumber && u.id_usuario != id.Value);
            }

            // Para nuevo usuario, verifica si ya existe el DNI
            return !dbContext.Usuario.Any(u => u.dni == dniNumber);
        }


    }
}
