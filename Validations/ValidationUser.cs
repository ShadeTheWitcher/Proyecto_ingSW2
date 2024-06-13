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

        public static bool ValidateUniqueEmail(Classes.Models.Admin_shopEntities dbContext, string correo, bool edit = false)
        {
            if (edit)
            {
                return dbContext.Usuario.Where(u => u.correo == correo).Where(u => u.correo != correo).Any();
            }
            return dbContext.Usuario.Any(u => u.correo == correo);
        }

        public static bool ValidateUniqueDNI(Classes.Models.Admin_shopEntities dbContext, string dni, bool edit = false)
        {
            if (!long.TryParse(dni, out long dniNumber))
            {
                // Si no se puede convertir a long, retorna falso o maneja el error según tu lógica.
                return false;
            }

            if (edit)
            {
                return dbContext.Usuario.Any(u => u.dni == dniNumber && u.dni != dniNumber);
            }

            return dbContext.Usuario.Any(u => u.dni == dniNumber);
        }


    }
}
