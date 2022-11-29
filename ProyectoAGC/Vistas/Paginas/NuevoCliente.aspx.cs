using AGCComercial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using ERP_Comercial.ProcesoJWT;
using ProyectoAGC.Models;
using System.Runtime.Remoting.Contexts;

namespace ProyectoAGC.Vistas.Paginas
{
    
    public partial class NuevoCliente : System.Web.UI.Page
    {
        PeticionHTTP peticionHTTP = new PeticionHTTP("http://localhost:50393");
        Modelo bd = new Modelo();

        //Mensajes de venta

        String correcto = @"<script type='text/javascript'>alert('Datos guardados correctamente');</script>";
        String falso = @"<script type='text/javascript'>alert('Ocurrío un error al intentar ingresar el registro');</script>";

        String vacio = @"<script type='text/javascript'>alert('Nose pueden enviar datos vacíos');</script>";
        String Duplicado = @"<script type='text/javascript'>alert('El cliente ingresado ya se encuentra en la base de datos');</script>";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardarClient_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                RFC_Cli = txtRFCClient.Text,
                Nombre = txtNom.Text,
                Direccion = txtDirecClient.Text,
                Telefono = txttelClient.Text,
                Correo = txtEmailClient.Text
            };

            var UsuarioDuplicado = bd.Cliente.Where(
                c => c.RFC_Cli == cliente.RFC_Cli && c.Nombre == cliente.Nombre && c.Telefono == cliente.Telefono &&
                c.Correo == cliente.Correo).FirstOrDefault();

            if (UsuarioDuplicado == null)
            {
                String EnviarJSON = JsonConvertidor.Objeto_Json(cliente);
                peticionHTTP.PedirComunicacion("Clientes/CrearCliente", MetodoHTTP.POST, TipoContenido.JSON, Session["jwt"].ToString());
                peticionHTTP.enviarDatos(EnviarJSON);

                String Estado = peticionHTTP.ObtenerJson();

                if (Estado != null)
                {
                    if(Estado == "true")
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "correcto", correcto, false);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "falso", falso, false);
                    }
                }
                
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Duplicado", Duplicado, false);
            }

        }
    }
}