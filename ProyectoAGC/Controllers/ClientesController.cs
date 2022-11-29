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
    public class ClientesController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar clientes a la base de datos-----------//

        [JWT]
        [ActionName("CrearCliente")]
        [HttpPost]

        public bool CrearCliente(Cliente cliente)
        {
            try
            {
                bd.Cliente.Add(cliente);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar cliente de la base de datos-----------//

        [JWT]
        [ActionName("MostrarCliente")]
        [HttpGet]

        public IQueryable<ClienteDTO> Get(String id)
        {
            IQueryable<ClienteDTO> clientesDTOs = from clientes in bd.Cliente
                                                   where clientes.ID == id
                                                   select new ClienteDTO
                                                   {
                                                       ID = clientes.ID,
                                                       Nombre = clientes.Nombre,
                                                       Direccion = clientes.Direccion,
                                                       Telefono = clientes.Telefono,
                                                       Correo = clientes.Correo,
                                                   };
            return clientesDTOs;
        }

        //-------Controlador para mostrar los clientes de la base de datos-----------//

        [JWT]
        [ActionName("MostrarClientes")]
        [HttpGet]

        public IQueryable<ClienteDTO> Get()
        {
            IQueryable<ClienteDTO> clientesDTOs = from clientes in bd.Cliente
                                                   select new ClienteDTO
                                                   {
                                                       ID = clientes.ID,
                                                       Nombre = clientes.Nombre,
                                                       Direccion = clientes.Direccion,
                                                       Telefono = clientes.Telefono,
                                                       Correo = clientes.Correo,
                                                   };
            return clientesDTOs;
        }


        //-------Controlador para Actualizar clientes de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarCliente")]
        [HttpPut]

        public bool ActualizarCliente(Cliente Cliente)
        {
            try
            {
                bd.Entry(Cliente).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar cliente de la base de datos-----------//

        [JWT]
        [ActionName("BorrarCliente")]
        [HttpDelete]

        public bool BorrarCliente(string id)
        {
            try
            {
                Cliente clientes = bd.Cliente.Find(id);
                bd.Entry(clientes).State = System.Data.Entity.EntityState.Deleted;
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
