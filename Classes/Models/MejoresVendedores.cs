using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Classes.Models
{
    public class MejoresVendedores
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double TotalRecaudado { get; set; }
        public List<float> Totales { get; set; }
        public List<DateTime> Fechas { get; set; }
    }
}
