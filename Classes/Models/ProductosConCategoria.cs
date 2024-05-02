using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Classes.Models
{
    public class ProductoConCategoria
    {
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public double precio_costo { get; set; }
        public double precio_venta { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
    }
}
