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
    public class ProveedoresController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar proveedor a la base de datos-----------//

        [JWT]
        [ActionName("AgregarProveedor")]
        [HttpPost]

        public bool AgregarProveedor(Proveedor proveedores)
        {
            try
            {
                bd.Proveedor.Add(proveedores);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un proveedor de la base de datos-----------//

        [JWT]
        [ActionName("MostrarProveedor")]
        [HttpGet]

        public IQueryable<ProveedorDTO> Get(String id)
        {
            IQueryable<ProveedorDTO> proveedoresDTOs = from proveedores in bd.Proveedor
                                                         where proveedores.ID == id
                                                         select new ProveedorDTO
                                                         {
                                                             ID = proveedores.ID,
                                                             Empresa = proveedores.Empresa,
                                                             RazonSocial = proveedores.RazonSocial,
                                                             Contacto = proveedores.Contacto,
                                                             Categoria = proveedores.Categoria,
                                                             Giro = proveedores.Giro,
                                                             Telefono = proveedores.Telefono,
                                                             Correo = proveedores.Correo,
                                                             Direccion = proveedores.Direccion,
                                                             Zona = proveedores.Zona
                                                         };
            return proveedoresDTOs;
        }

        //-------Controlador para mostrar proveedores de la base de datos-----------//

        [JWT]
        [ActionName("MostrarProveedores")]
        [HttpGet]

        public IQueryable<ProveedorDTO> Get()
        {
            IQueryable<ProveedorDTO> proveedoresDTOs = from proveedores in bd.Proveedor
                                                         select new ProveedorDTO
                                                         {
                                                             ID = proveedores.ID,
                                                             Empresa = proveedores.Empresa,
                                                             RazonSocial = proveedores.RazonSocial,
                                                             Contacto = proveedores.Contacto,
                                                             Categoria = proveedores.Categoria,
                                                             Giro = proveedores.Giro,
                                                             Telefono = proveedores.Telefono,
                                                             Correo = proveedores.Correo,
                                                             Direccion = proveedores.Direccion,
                                                             Zona = proveedores.Zona
                                                         };
            return proveedoresDTOs;
        }



        //-------Controlador para Actualizar proveedor de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarProveedor")]
        [HttpPut]

        public bool ActualizarProveedor(Proveedor proveedores)
        {
            try
            {
                bd.Entry(proveedores).State = System.Data.Entity.EntityState.Modified;
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
        [ActionName("BorrarProveedor")]
        [HttpDelete]

        public bool BorrarProveedor(string id)
        {
            try
            {
                Proveedor provedor = bd.Proveedor.Find(id);
                bd.Entry(provedor).State = System.Data.Entity.EntityState.Deleted;
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
