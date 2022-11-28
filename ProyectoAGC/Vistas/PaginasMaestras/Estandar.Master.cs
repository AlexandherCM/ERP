using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAGC.Vistas.PaginasMaestras
{
    public partial class Estandar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void LogOut_Click(object sender, ImageClickEventArgs e)
        {
            Response.RedirectToRoute("BorrarJWT");
        }
    }
}