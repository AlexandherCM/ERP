using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ProyectoAGC
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapPageRoute("BorrarJWT", "Logout", "~/Vistas/Logout.aspx");

            RouteTable.Routes.MapPageRoute("CerrarSesion", "Login", "~/Vistas/Login.aspx");
            //Menu
            RouteTable.Routes.MapPageRoute("Menu", "menu", "~/Vistas/Paginas/Menu.aspx");
            //Módulo ventas
            RouteTable.Routes.MapPageRoute("Orden", "Orden", "~/Vistas/Paginas/OrdenVenta.aspx");
            //NuevaCotizacion
            RouteTable.Routes.MapPageRoute("NCotizacion", "nCotizacion", "~/Vistas/Paginas/NuevaCotizacion.aspx");
            //Ventas
            RouteTable.Routes.MapPageRoute("Ventas", "Ventas", "~/Vistas/Paginas/Ventas.aspx");
            //ProductosCotizados
            RouteTable.Routes.MapPageRoute("ProductosCo", "Productos", "~/Vistas/Paginas/ProductosCotizados.aspx");
            //NProducto
            RouteTable.Routes.MapPageRoute("NProducto", "NProducto", "~/Vistas/Paginas/NuevoProducto.aspx");
            //NuevoCliente
            RouteTable.Routes.MapPageRoute("NCliente", "NCliente", "~/Vistas/Paginas/NuevoCliente.aspx");
            //NuevoProveedor
            RouteTable.Routes.MapPageRoute("NProveedor", "NProveedor", "~/Vistas/Paginas/NuevoProveedor.aspx");
            //Cotizaciones
            RouteTable.Routes.MapPageRoute("Cotizacones", "Cotizaciones", "~/Vistas/Paginas/Cotizaciones.aspx");
            //CatalogoClinetes
            RouteTable.Routes.MapPageRoute("CatalogoC", "CatalogoC", "~/Vistas/Paginas/CatalogoClientes.aspx");
            //CatalogoProveedores
            RouteTable.Routes.MapPageRoute("CatalogoPro", "CatalogoPro", "~/Vistas/Paginas/CatalogoProveedores.aspx");
            //CatalogoProductos
            RouteTable.Routes.MapPageRoute("CatalogoP", "CatalogoP", "~/Vistas/Paginas/CatalogoProductos.aspx");
            //Catalogos
            RouteTable.Routes.MapPageRoute("Catalogos", "Catalogos", "~/Vistas/Paginas/Catalogos.aspx");

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
