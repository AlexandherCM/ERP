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
    public class PedidosController : ApiController
    {
        Modelo bd = new Modelo();

        //-------Controlador para agregar pedidos a la base de datos-----------//

        [JWT]
        [ActionName("AgregarPedido")]
        [HttpPost]

        public bool CrearPedido(Pedido pedidoes)
        {
            try
            {
                bd.Pedido.Add(pedidoes);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un pedido de la base de datos-----------//

        [JWT]
        [ActionName("MostrarPedido")]
        [HttpGet]

        public IQueryable<PedidoDTO> Get(String id)
        {
            IQueryable<PedidoDTO> pedidosDTOs = from pedidos in bd.Pedido
                                                 where pedidos.PedidoID == id
                                                 select new PedidoDTO
                                                 {
                                                     PedidoID = pedidos.PedidoID,
                                                     RFC = pedidos.RFC,
                                                     IDProducto = pedidos.IDProducto,
                                                     IDUsuario = pedidos.IDUsuario,
                                                     Cantidad = pedidos.Cantidad,
                                                     PrecioUnitario = pedidos.PrecioUnitario,
                                                     Total = pedidos.Total,
                                                     ClabeBancaria = pedidos.ClabeBancaria,
                                                     FechaInicio = pedidos.FechaInicio,
                                                     FechaVencimiento = pedidos.FechaVencimiento,
                                                 };
            return pedidosDTOs;
        }



        //-------Controlador para Actualizar pedido de la base de datos-----------//

        [JWT]
        [ActionName("ActualizarPedido")]
        [HttpPut]

        public bool ActualizarPedido(Pedido pedidos)
        {
            try
            {
                bd.Entry(pedidos).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar pedido de la base de datos-----------//

        [JWT]
        [ActionName("BorrarPedido")]
        [HttpDelete]

        public bool BorrarPedido(string id)
        {
            try
            {
                Pedido pedido = bd.Pedido.Find(id);
                bd.Entry(pedido).State = System.Data.Entity.EntityState.Deleted;
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
