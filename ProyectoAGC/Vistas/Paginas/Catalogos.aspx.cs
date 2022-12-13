using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAGC.Vistas.Paginas
{
    public partial class Catalogos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CatalogoC");
        }

        protected void btnProveedores_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CatalogoPro");
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("CatalogoP");
        }
    }
}