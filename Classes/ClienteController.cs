using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Classes
{
    internal class ClienteController
    {
        private static Admin_shopEntities db = new Admin_shopEntities();

        public static IEnumerable<Cliente> obtenerClientes()
        {
            var clientes = from p in db.Cliente
                           where p.estado == "1"
                           where p.id_usuario == AppState.idUser
                           select p;
            return clientes.ToList();
        }

        public static IEnumerable<Cliente> obtenerTodosClientes()
        {
            var clientes = from p in db.Cliente
                           where p.estado == "1"
                           select p;
            return clientes.ToList();
        }

        public static Cliente obtenerClientePorId(int? id)
        {
            var cliente = (from p in db.Cliente
                           where p.id_cliente == id
                           select p).FirstOrDefault();
            return cliente;
        }

        public static void editarCliente(int idCliente, string nombre, string apellido, string correo, long numeroTelefono, string usuarioInstagram, string domicilio, long dni)
        {
            Cliente clienteEditado = db.Cliente.Where(d => d.id_cliente == idCliente).First();

            clienteEditado.nombre = nombre;
            clienteEditado.apellido = apellido;
            clienteEditado.correo = correo;
            clienteEditado.telefono = numeroTelefono;
            clienteEditado.instagram = usuarioInstagram;
            clienteEditado.domicilio = domicilio;
            clienteEditado.dni = dni;

            db.Entry(clienteEditado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static IEnumerable<Venta_detalle> detallesVenta(int id_venta)
        {
            Admin_shopEntities dbUpdate = new Admin_shopEntities();
            var detailVenta = (from d in dbUpdate.Venta_detalle
                                                      where d.id_venta == id_venta
                                                      where d.estado =="1"
                                                      select d);

            return detailVenta.ToList();
        }
        public static void eliminarCliente(int id)
        {
            Cliente clienteToDelete = db.Cliente.Where(d => d.id_cliente == id).First();

            clienteToDelete.estado = "0";

            db.Entry(clienteToDelete).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void addCliente(string nombre, string apellido, string correo, long numeroTelefono, string usuarioInstagram, string domicilio, long dni)
        {
            try
            {

                Cliente nuevoCliente = new Cliente();

                nuevoCliente.nombre = nombre;
                nuevoCliente.apellido = apellido;
                nuevoCliente.correo = correo;
                nuevoCliente.telefono = numeroTelefono;
                nuevoCliente.instagram = usuarioInstagram;
                nuevoCliente.dni = dni;
                nuevoCliente.domicilio = domicilio;
                nuevoCliente.id_usuario = 2;
                nuevoCliente.estado = "1";

                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;  
            }
        }

        public static IEnumerable<Cliente> getClientesBySearch(string searchText)
        {
            var normalizedSearchText = searchText?.ToLower() ?? string.Empty;

            var clientes = from p in db.Cliente
                           where p.estado == "1"
                           && (p.nombre.ToLower().Contains(normalizedSearchText)
                                || p.apellido.ToLower().Contains(normalizedSearchText))
                           select p;

            return clientes.ToList();
        }


        public static List<MejoresClientes> OchoMejoresClientes(DateTime f_desde, DateTime f_hasta)
        {
            DateTime fechadesde = f_desde.AddDays(-1);
            var mejoresClientes = (from vd in db.Venta
                                                     where vd.fecha >= fechadesde
                                                     where vd.fecha <= f_hasta
                                                     where vd.id_cliente != null
                                                     join c in db.Cliente on vd.id_cliente equals c.id_cliente into clienteGroup
                                                     from c in clienteGroup.DefaultIfEmpty()
                                                     group vd by c != null ? c.nombre : "Cliente no especificado" into g
                                                     select new MejoresClientes
                                                     {
                                                         nombre = g.Key,
                                                         total = g.Sum(item => item.total)
                                                     })
                    .OrderByDescending(mc => mc.total)
                    .Take(8); 
            return mejoresClientes.ToList();
        }
    }
}
