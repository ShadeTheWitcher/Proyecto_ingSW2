﻿using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_AdminShop.Classes
{
    internal class ProductoController
    {
        private static Admin_shopEntities db = new Admin_shopEntities();

        public static IEnumerable<Producto> ProductsAll()
        {
            Admin_shopEntities UpdatedDatabase = new Admin_shopEntities();

            var productos = from p in UpdatedDatabase.Producto
                            join c in UpdatedDatabase.Categoria on p.id_categoria equals c.id_categoria
                            where p.estado == "1"
                            where p.stock > 0
                            select p; // selecciona el producto en lugar de un tipo anónimo

            return productos.ToList();
        }

        public static IEnumerable<ProductoConCategoria> productoConCategoriasAll()
        {
            Admin_shopEntities UpdatedDatabase = new Admin_shopEntities();
            var productos = from p in UpdatedDatabase.Producto
                            join c in UpdatedDatabase.Categoria on p.id_categoria equals c.id_categoria
                            where p.estado == "1"
                            where p.stock > 0
                            select new ProductoConCategoria
                            {
                                id_producto = p.id_producto,
                                descripcion = p.descripcion,
                                precio_costo = p.precio_costo,
                                precio_venta = p.precio_venta,
                                stock = p.stock,
                                categoria = c.descripcion // Aquí asignamos la descripción de la categoría
                            };
            return productos.ToList();
        }


        public static IEnumerable<Producto> obtenerProductosPorCategoria(int idCategoria = 1) // id_categoria 1 es el valor por defecto
        {
            // Obtener productos por categoría específica, 1 por defecto
            var productos = from p in db.Producto
                            join c in db.Categoria on p.id_categoria equals c.id_categoria
                            where p.estado == "1" && p.id_categoria == idCategoria
                            where p.stock > 0
                            select p; 

            return productos.ToList();
        }

        public static IEnumerable<Producto> obtenerProductosPorNombre(string searchText)
        {
            // Normaliza el texto de búsqueda para una comparación no sensible a mayúsculas y minúsculas
            var normalizedSearchText = searchText?.ToLower() ?? string.Empty;

            // Realiza la consulta a la base de datos buscando coincidencias parciales en los nombres de los productos
            var productos = from p in db.Producto
                            where p.estado == "1" && p.descripcion.ToLower().Contains(normalizedSearchText)
                            select p;

            return productos.ToList();
        }


        public static void addProduct(string description, int categoria, float precioCosto, float precioVenta, int stock)
        {

            Producto nuevoProducto = new Producto();
            
            nuevoProducto.descripcion = description;
            nuevoProducto.id_categoria = categoria;
            nuevoProducto.precio_costo = precioCosto;
            nuevoProducto.precio_venta = precioVenta;
            nuevoProducto.stock = stock;
            nuevoProducto.create_by = 1;
            nuevoProducto.estado = "1";


            db.Producto.Add(nuevoProducto);

            db.SaveChanges();
            
        }

        

        public bool RegistrarProducto(string descripcion, object selectedItem, string precioCostoStr, string precioVentaStr, string stockStr)
        {
            string errorMessage;
            Producto producto;

            // Validar los campos utilizando el método ValidarCamposProducto
            if (!ValidarCamposProducto(descripcion, selectedItem, precioCostoStr, precioVentaStr, stockStr, out errorMessage, out producto))
            {
                throw new ArgumentException(errorMessage);
            }

            try
            {
                // Aquí podrías llamar a tu método para insertar el producto en la base de datos
                // Utilizo los valores ya convertidos a float según la lógica de ValidarCamposProducto
                InsertarProducto(descripcion, producto.precio_costo, producto.precio_venta, producto.stock, producto.id_categoria, 1);

                return true; // Indicación de que el registro fue exitoso
            }
            catch (Exception ex)
            {
                // Manejo de errores específicos de la base de datos u otra lógica de inserción
                throw new Exception("Error al insertar el producto.", ex);
            }
        }

       





        public static void InsertarProducto(string descripcion, double precioCosto, double precioVenta, int stock, int idCategoria, int createBy)
        {
            // Llama al procedimiento almacenado de inserción de producto
            db.InsertarProductoDB(descripcion, precioCosto, precioVenta, stock, idCategoria, createBy);
        }


        public static void deleteProduct(int id) {
            Producto productoToDelete = db.Producto.Where(d => d.id_producto == id).First();

            productoToDelete.estado = "0";

            db.Entry(productoToDelete).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static Producto getOneProduct(int id)
        {
            var producto = (from p in db.Producto
                            join c in db.Categoria on p.id_categoria equals c.id_categoria
                            where p.id_producto == id
                            select new
                            {
                                Producto = p,
                                CategoriaDescripcion = c.descripcion
                            }).FirstOrDefault();

            if (producto != null)
            {
                producto.Producto.Categoria.descripcion = producto.CategoriaDescripcion;
                return producto.Producto;
            }
            else
            {
                return null;
            }
        }




        public static void editProduct(int id, int categoria, string description, float precioCosto, float precioVenta, int stock)
        {
            Producto productoEditado = db.Producto.Where(d => d.id_producto == id).First();

            productoEditado.descripcion = description;
            productoEditado.precio_costo = precioCosto;
            productoEditado.precio_venta = precioVenta;
            productoEditado.stock = stock;
            productoEditado.id_categoria = categoria;
            
            db.Entry(productoEditado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static List<Producto> lowStockProducts()
        {   
            db = new Admin_shopEntities();
            var lowStockProductsList = (from p in db.Producto
                                        where p.estado == "1"
                                        where p.stock <= 5
                                        select p).OrderByDescending(m=> m.stock);
            return lowStockProductsList.ToList();
        }

        public static List<Producto> outOfStockProducts()
        {
            db = new Admin_shopEntities();
            var outOfStockProductsList = (from p in db.Producto
            where p.estado == "1"
            where p.stock == 0
                                                                                                                                                                     select p).OrderByDescending(m => m.stock);
            return outOfStockProductsList.ToList();
        }



        //validaciones
        private bool IsCategorySelected(object selectedItem)
        {
            return selectedItem != null;
        }

        private bool IsDescriptionValid(string description)
        {
            return !string.IsNullOrEmpty(description);
        }

        private bool IsPriceValid(decimal price)
        {
            return price > 0;
        }

        private bool IsStockValid(int stock)
        {
            return stock >= 0;
        }


        public bool ValidarCamposProducto(string descripcion, object selectedItem, string precioCostoStr, string precioVentaStr, string stockStr,
        out string errorMessage,
        out Producto producto)
        {
            producto = null;
            errorMessage = string.Empty;

            if (!IsCategorySelected(selectedItem))
            {
                errorMessage = "Por favor, seleccione una categoría.";
                return false;
            }

            if (!IsDescriptionValid(descripcion))
            {
                errorMessage = "La descripción no puede estar vacía.";
                return false;
            }

            if (!decimal.TryParse(precioCostoStr, out decimal precioCosto) || !IsPriceValid(precioCosto))
            {
                errorMessage = "Ingrese un precio de costo válido (mayor a 0).";
                return false;
            }

            if (!decimal.TryParse(precioVentaStr, out decimal precioVenta) || !IsPriceValid(precioVenta))
            {
                errorMessage = "Ingrese un precio de venta válido (mayor a 0).";
                return false;
            }

            if (!int.TryParse(stockStr, out int stock) || !IsStockValid(stock))
            {
                errorMessage = "El stock no puede ser negativo.";
                return false;
            }

            if (selectedItem is ComboBoxItem comboBoxItem)
            {
                int categoriaId = comboBoxItem.Value;

                producto = new Producto
                {
                    descripcion = descripcion,
                    precio_costo = Convert.ToDouble(precioCosto), // Convertir a float si Producto usa float
                    precio_venta = Convert.ToDouble(precioVenta), // Convertir a float si Producto usa float
                    stock = stock,
                    id_categoria = categoriaId
                };

                return true;
            }
            else
            {
                errorMessage = "Categoría seleccionada no es válida.";
                return false;
            }
        }






    }
}
