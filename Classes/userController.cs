using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taller_AdminShop.Classes.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public static string validarCampos(string nombre, string apellido, string email, string contraseña, string dni, string instagram, string telefono, out long dniParsed, out long telefonoParsed  ,bool edit = false)
        {
            dniParsed = 0;
            telefonoParsed = 0;

            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(apellido))
                return "El apellido no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(email))
                return "El correo electrónico no puede estar vacío.";

            if (edit)
            {
                //no verifica pw si se esta editando
            }
            else
            {
                if (string.IsNullOrWhiteSpace(contraseña))
                    return "La contraseña no puede estar vacía.";

                if (!ValidationUser.ValidationLengh(contraseña, 6, 20))
                    return "La contraseña debe tener entre 6 y 20 caracteres.";
            }
            

            if (string.IsNullOrWhiteSpace(dni) || !long.TryParse(dni, out dniParsed))
                return "El DNI no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(instagram))
                return "El nombre de Instagram no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(telefono) || !long.TryParse(telefono, out telefonoParsed))
                return "El teléfono no puede estar vacío.";





            if (!ValidationUser.ValidationLengh(nombre, 3, 50))
                return "El nombre debe tener entre 3 y 50 caracteres.";

            if (!ValidationUser.ValidationLengh(apellido, 3, 50))
                return "El apellido debe tener entre 3 y 50 caracteres.";

            if (!ValidationUser.ValidationEmail(email))
                return "El correo electrónico no es válido.";



            if (!ValidationUser.ValidationLengh(dni, 3, 50) || !long.TryParse(dni, out dniParsed))
                return "El DNI no es válido.";

            if (!ValidationUser.ValidationLengh(instagram, 3, 50))
                return "El nombre de Instagram debe tener entre 3 y 50 caracteres.";

            if (!ValidationUser.ValidationLengh(telefono, 3, 50) || !long.TryParse(telefono, out telefonoParsed))
                return "El teléfono no es válido.";

            return null;
        }

        public static string RegistrarUsuario(string nombre, string apellido, string email, string contraseña, string dni, string instagram, string telefono, string rol)
        {
            long dniParsed, telefonoParsed;
            string validacion = validarCampos(nombre, apellido, email, contraseña, dni, instagram, telefono, out dniParsed, out telefonoParsed);

            if (validacion != null)
                return validacion;

            using (Classes.Models.Admin_shopEntities db = new Classes.Models.Admin_shopEntities())
            {
                if (ValidationUser.ValidateUniqueEmail(db, email))
                    return "Correo ya registrado.";

                if (!ValidationUser.ValidateUniqueDNI(db, dni))
                    return "DNI ya registrado por otro usuario.";

                Usuario user = new Usuario
                {
                    nombre = nombre.Trim(),
                    apellido = apellido.Trim(),
                    contraseña = Classes.Encrypt.GetSHA256(contraseña.Trim()),
                    correo = email.Trim(),
                    dni = dniParsed,
                    instagram = instagram.Trim(),
                    telefono = telefonoParsed,
                    estado = "1"
                };

                switch (rol)
                {
                    case "Vendedor":
                        user.tipo_usuario = 2;
                        break;
                    case "Administrador":
                        user.tipo_usuario = 3;
                        break;
                    default:
                        return "El rol seleccionado no es válido.";
                }

                db.Usuario.Add(user);
                db.SaveChanges();

                return "Usuario creado correctamente!";
            }
        }


        public static string EditarUsuario(int id, string nombre, string apellido, string email, string dni, string instagram, string telefono, string rol)
        {
            // Validar campos y obtener valores parseados
            long dniParsed, telefonoParsed;
            string validacion = validarCampos(nombre, apellido, email, "111" , dni, instagram, telefono ,out dniParsed, out telefonoParsed, true);

            if (!string.IsNullOrEmpty(validacion))
                return validacion;

            using (Admin_shopEntities db = new Admin_shopEntities())
            {
                // Buscar usuario por ID
                Usuario user = db.Usuario.FirstOrDefault(u => u.id_usuario == id);

                if (user == null)
                    return "Usuario no encontrado.";

                // Validar correo único si se está editando
                if (!ValidationUser.ValidateUniqueEmail(db, email, id))
                    return "Correo ya registrado por otro usuario.";

                if (!ValidationUser.ValidateUniqueDNI(db, dni, id))
                    return "DNI ya registrado por otro usuario.";

                // Actualizar los datos del usuario
                user.nombre = nombre.Trim();
                user.apellido = apellido.Trim();
                user.correo = email.Trim();
                user.dni = dniParsed;
                user.instagram = instagram.Trim();
                user.telefono = telefonoParsed;
                user.tipo_usuario = rol == "Vendedor" ? 2 : 3;

                // Guardar cambios en la base de datos
                db.SaveChanges();
                return "Usuario modificado correctamente!";
            }
        }





    }
}
