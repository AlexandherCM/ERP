using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAGC.Vistas.Paginas
{
    public partial class Menu : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:50393/");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String Nombre = (String)Session["UsuarioActivo"];

                string mensaje1 = ("Bienvenido: " + Nombre + "');</script>");
                string mensaje2 = (@"<script type='text/javascript'>alert('" + mensaje1);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "InicioSesion", mensaje2, false);
            }
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Vistas/Paginas/Ventas.aspx");
        }

        protected void btnCatalogos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Vistas/Paginas/Catalogos.aspx");
        }

        // -------------------------------------------------------------------------------------------------------------------------------

        protected void btnFinanzas_Click(object sender, EventArgs e)
        {
            peticion.PedirComunicacion("Usuario/Expirar", MetodoHTTP.GET, TipoContenido.JSON, Session["jwt"].ToString());
            String mensaje = peticion.ObtenerJson();

            if (mensaje != null)
            {
                string mensaje1 = ("Petición: " + mensaje + "');</script>");
                string mensaje2 = (@"<script type='text/javascript'>alert('" + mensaje1);

                ScriptManager.RegisterStartupScript(this, typeof(Page), "InicioSesion", mensaje2, false);
            }
            else
            {
                Response.RedirectToRoute("BorrarJWT");
            }
        }
    }
}