using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Classes
{
    public class SaleController
    {
        private static Admin_shopEntities db = new Admin_shopEntities();
        public static IEnumerable<Venta> AllVentas() {
            IEnumerable<Venta> ventas = from d in db.Venta
                         where d.estado == "1"
                         where d.id_usuario == AppState.idUser
                         select d;
            return ventas;
        }

        public static IEnumerable<Venta> AllVentasAdmin()
        {
            IEnumerable<Venta> ventas = from d in db.Venta
                                        join p in db.Usuario on d.id_usuario equals p.id_usuario
                                        where d.estado == "1"
                                        select d;
            return ventas;
        }

        public static Venta oneVenta(int id)
        {
            return (from d in db.Venta where d.id_venta == id select d).First();
        }


        public static IEnumerable<Venta> VentasDesdeHasta(DateTime f_desde, DateTime f_hasta)
        {
            db = new Admin_shopEntities();
            DateTime fechaDesde = f_desde.AddDays(-1);
            IEnumerable<Venta> venta = from d in db.Venta
                                       where d.estado == "1"
                                       where d.id_usuario == AppState.idUser
                                       where d.fecha >= fechaDesde
                                       where d.fecha <= f_hasta
                                       select d;
            return venta;
            
        }

        public static IEnumerable<Venta> VentasDesdeAdmin(DateTime f_desde, DateTime f_hasta)
        {
            db = new Admin_shopEntities();
            DateTime fechaDesde = f_desde.AddDays(-1);
            IEnumerable<Venta> venta = from d in db.Venta
                                       where d.estado == "1"
                                       where d.fecha >= fechaDesde
                                       where d.fecha <= f_hasta
                                       select d;
            return venta;
        }

        public static void controlStock(int id_product, int cant)
        {
            Producto product = db.Producto.Where(d => d.id_producto == id_product).First();
            product.stock -= cant;
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static List<CategoriaConCantidadVendida> CategoriasConCantidadVendida(DateTime f_desde, DateTime f_hasta)
        {
            using (Admin_shopEntities db = new Admin_shopEntities())
            {
                DateTime fechadesde = f_desde.AddDays(-1);
                var ventasDesdeHasta = from v in db.Venta
                                       where v.fecha >= fechadesde
                                       where v.fecha <= f_hasta
                                       select v;
                var categoriasConCantidad = from vd in db.Venta_detalle
                                            where ventasDesdeHasta.Select(v => v.id_venta).Contains(vd.id_venta)
                                            join p in db.Producto on vd.id_producto equals p.id_producto
                                            join c in db.Categoria on p.id_categoria equals c.id_categoria
                                            group vd by c.descripcion into g
                                            select new CategoriaConCantidadVendida
                                            {  
                                                categoria = g.Key,
                                                cantidad = g.Sum(item => item.cantidad)
                                            };

                return categoriasConCantidad.ToList();
            }
        }
    }
}
