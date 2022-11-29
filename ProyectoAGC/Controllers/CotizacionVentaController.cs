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
    public class CotizacionVentaController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar Cotizaciones a la base de datos-----------//

        [JWT]
        [ActionName("CrearCotizacion")]
        [HttpPost]

        public bool CrearCotizacion(CotizacionVenta cotizacion)
        {
            try
            {
                bd.Cotizacion.Add(cotizacion);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una cotizacion de la base de datos-----------//

        [JWT]
        [ActionName("MostrarCotizacion")]
        [HttpGet]

        public IQueryable<CotizacionVentaDTO> Get(String id)
        {
            IQueryable<CotizacionVentaDTO> CotizacionesDTOs = from cotizaciones in bd.Cotizacion
                                                         where cotizaciones.ID == id
                                                         select new CotizacionVentaDTO
                                                         {
                                                             ID = cotizaciones.ID,
                                                             RFC_Cli = cotizaciones.RFC_Cli,
                                                             IDProducto = cotizaciones.IDProducto,
                                                             IDUsuario = cotizaciones.IDUsuario,
                                                             Cantidad = cotizaciones.Cantidad,
                                                             Descripcion = cotizaciones.Descripcion,
                                                             Precio = cotizaciones.Precio,
                                                             Total = cotizaciones.Total,
                                                             Fecha = cotizaciones.Fecha,
                                                             Remision_FolioRemision = cotizaciones.Remision_FolioRemision,
                                                             Imagen = cotizaciones.Imagen
                                                         };
            return CotizacionesDTOs;
        }



        //-------Controlador para Actualizar cotizacion de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarCotizacion")]
        [HttpPut]

        public bool ActualizarCotizacion(CotizacionVenta cotizacion)
        {
            try
            {
                bd.Entry(cotizacion).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar cotizacion de la base de datos-----------//

        [JWT]
        [ActionName("BorrarCotizacion")]
        [HttpDelete]

        public bool BorrarCotizacion(string id)
        {
            try
            {
                CotizacionVenta cotizacion = bd.Cotizacion.Find(id);
                bd.Entry(cotizacion).State = System.Data.Entity.EntityState.Deleted;
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
