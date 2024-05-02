using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taller_AdminShop.Classes.Models;

namespace Proyecto_Taller_AdminShop.Classes
{   
    
    public class UserController
    {
        private static Admin_shopEntities db = new Admin_shopEntities();

        public static IEnumerable<Usuario> UsersAll()
        {
            db = new Admin_shopEntities();
            var users = from d in db.Usuario
                        where d.estado == "1"
                        where d.id_usuario != AppState.idUser
                        select d;
            return users.ToList();
        }

        public static Usuario OneUser(int id)
        {   
            return db.Usuario.Where(d => d.id_usuario == id).Where(d=> d.estado == "1").First();
        }

        public static void deleteUser(int id_user)
        {
            Usuario user_delete = db.Usuario.Where(d => d.id_usuario == id_user).First();

            user_delete.estado = "0";

            db.Entry(user_delete).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void editUser(int id, string name, string lastname,string mail, long tf, long dni, string ig, int rol)
        {
            Usuario user_edit = db.Usuario.Where(d=> d.id_usuario == id).First();

            user_edit.nombre = name;
            user_edit.apellido = lastname;
            user_edit.correo = mail;
            user_edit.telefono = tf;
            user_edit.instagram = ig;
            user_edit.dni = dni;
            user_edit.tipo_usuario = rol;

            db.Entry(user_edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static List<MejoresVendedores> mejoresVendedores(DateTime f_desde, DateTime f_hasta)
        {
            DateTime fechaDesde = f_desde.AddDays(-1);
            var mejoresVendedores = db.Venta
                        .Where(d=> d.fecha >= fechaDesde)
                        .Where(d => d.fecha <= f_hasta)
                        .Include(v => v.Usuario)
                        .GroupBy(v => v.id_usuario)
                        .Select(g => new MejoresVendedores{
                            UsuarioId = g.Key,
                            Nombre = g.FirstOrDefault().Usuario.nombre,
                            Apellido = g.FirstOrDefault().Usuario.apellido,
                            TotalRecaudado = g.Sum(v => v.total),
                            Totales = g.Select(v => (float)v.total).OrderBy(fecha => fecha).ToList(),
                            Fechas = g.Select(v => (DateTime)v.fecha).OrderBy(fecha => fecha).ToList(),
                        })
                        .OrderByDescending(g => g.TotalRecaudado)
                        .Take(3);

            return mejoresVendedores.ToList();
        }
    }
}
