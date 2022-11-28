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
    public class FacturasController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar Fcturas a la base de datos-----------//

        [JWT]
        [ActionName("CrearFactura")]
        [HttpPost]

        public bool CrearFactura(Factura facturas)
        {
            try
            {
                bd.Factura.Add(facturas);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una Facturas de la base de datos-----------//

        [JWT]
        [ActionName("MostrarFactura")]
        [HttpGet]

        public IQueryable<FacturaDTO> Get(String id)
        {
            IQueryable<FacturaDTO> facturasDTOs = from facturas in bd.Factura
                                                   where facturas.FolioFac == id
                                                   select new FacturaDTO
                                                   {
                                                       FolioFac = facturas.FolioFac,
                                                       FolioRemision = facturas.FolioRemision,
                                                       PrecioUni = facturas.PrecioUni,
                                                       Importe = facturas.Importe,
                                                       Subtotal = facturas.Subtotal,
                                                       IVA = facturas.IVA,
                                                       Total = facturas.Total,
                                                       FechaHora = facturas.FechaHora,
                                                       MetodoPago = facturas.MetodoPago,
                                                       FormaPago = facturas.FormaPago,
                                                   };
            return facturasDTOs;
        }



        //-------Controlador para Actualizar factura de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarFactura")]
        [HttpPut]

        public bool ActualizarFactura(Factura facturas)
        {
            try
            {
                bd.Entry(facturas).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar factura de la base de datos-----------//

        [JWT]
        [ActionName("BorrarFactura")]
        [HttpDelete]

        public bool Borrarfactura(string id)
        {
            try
            {
                Factura facturas = bd.Factura.Find(id);
                bd.Entry(facturas).State = System.Data.Entity.EntityState.Deleted;
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
