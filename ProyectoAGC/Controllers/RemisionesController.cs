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
    public class RemisionesController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar remision a la base de datos-----------//

        [JWT]
        [ActionName("AgregarRemision")]
        [HttpPost]

        public bool Agregarremision(Remision Remisiones)
        {
            try
            {
                bd.Remision.Add(Remisiones);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una remision de la base de datos-----------//

        [JWT]
        [ActionName("MostrarRemision")]
        [HttpGet]

        public IQueryable<RemisionDTO> Get(String id)
        {
            IQueryable<RemisionDTO> RemisionesDTOs = from Remison in bd.Remision
                                                       where Remison.FolioRemision == id
                                                       select new RemisionDTO
                                                       {
                                                           FolioRemision = Remison.FolioRemision,
                                                           Folio = Remison.Folio,
                                                           Responsable = Remison.Responsable,
                                                           FechaEntrega = Remison.FechaEntrega,
                                                           CotizacionVentas_Folio = Remison.CotizacionVentas_Folio,
                                                           CotizacionVenta_Folio = Remison.CotizacionVenta_Folio,
                                                           Factura_FolioFac = Remison.Factura_FolioFac,
                                                       };
            return RemisionesDTOs;
        }

        //-------Controlador para mostrar un proveedor de la base de datos-----------//

        [JWT]
        [ActionName("MostrarRemisiones")]
        [HttpGet]

        public IQueryable<RemisionDTO> Get()
        {
            IQueryable<RemisionDTO> remisionesDTOs = from remison in bd.Remision
                                                       select new RemisionDTO
                                                       {
                                                           FolioRemision = remison.FolioRemision,
                                                           Folio = remison.Folio,
                                                           Responsable = remison.Responsable,
                                                           FechaEntrega = remison.FechaEntrega,
                                                           CotizacionVentas_Folio = remison.CotizacionVentas_Folio,
                                                           CotizacionVenta_Folio = remison.CotizacionVenta_Folio,
                                                           Factura_FolioFac = remison.Factura_FolioFac,
                                                       };
            return remisionesDTOs;
        }




        //-------Controlador para Actualizar remision de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarRemision")]
        [HttpPut]

        public bool ActualizarRemision(Remision Remisiones)
        {
            try
            {
                bd.Entry(Remisiones).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar remision de la base de datos-----------//

        [JWT]
        [ActionName("BorrarRemision")]
        [HttpDelete]

        public bool BorrarRemision(string id)
        {
            try
            {
                Remision Remisiones = bd.Remision.Find(id);
                bd.Entry(Remisiones).State = System.Data.Entity.EntityState.Deleted;
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
