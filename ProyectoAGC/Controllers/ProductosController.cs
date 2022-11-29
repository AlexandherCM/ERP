using AGCComercial.Models;
using ERP_Comercial.ProcesoJWT;
using ProyectoAGC.Models; //Adaptar la redirección de ser necesario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP_Comercial.Controllers
{
    public class ProductosController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar productos a la base de datos-----------//

        [JWT]
        [ActionName("AgregarProducto")]
        [HttpPost]

        public bool AgregarProducto(Producto productos)
        {
            try
            {
                bd.Producto.Add(productos);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un producto de la base de datos-----------//

        [JWT]
        [ActionName("MostrarProducto")]
        [HttpGet]

        public IQueryable<ProductoDTO> Get(String id)
        {
            IQueryable<ProductoDTO> productosDTOs = from productos in bd.Producto
                                                     where productos.ID == id
                                                     select new ProductoDTO
                                                     {
                                                         ID = productos.ID,
                                                         Nombre = productos.Nombre,
                                                         Descripcion = productos.Descripcion,
                                                         Precio = productos.Precio,
                                                         Categoria = productos.Categoria,
                                                         Imgen = productos.Imgen
                                                     };
            return productosDTOs;
        }

        //-------Controlador para mostrar productos de la base de datos-----------//

        [JWT]
        [ActionName("MostrarProductos")]
        [HttpGet]

        public IQueryable<ProductoDTO> Get()
        {
            IQueryable<ProductoDTO> productosDTOs = from productos in bd.Producto
                                                     select new ProductoDTO
                                                     {
                                                         ID = productos.ID,
                                                         Nombre = productos.Nombre,
                                                         Descripcion = productos.Descripcion,
                                                         Precio = productos.Precio,
                                                         Categoria = productos.Categoria
                                                     };
            return productosDTOs;
        }



        //-------Controlador para Actualizar producto de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarProducto")]
        [HttpPut]

        public bool ActualizarProducto(Producto productos)
        {
            try
            {
                bd.Entry(productos).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar producto de la base de datos-----------//

        [JWT]
        [ActionName("BorrarProducto")]
        [HttpDelete]

        public bool BorrarProducto(string id)
        {
            try
            {
                Producto productos = bd.Producto.Find(id);
                bd.Entry(productos).State = System.Data.Entity.EntityState.Deleted;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
