using AGCComercial.Models;
using ERP_Comercial.ProcesoJWT;
using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAGC.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:50393/");
        String InicioSesion = @"<script type='text/javascript'>alert('Usuario y/o contraseña incorrectos.');</script>";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            InicioSesion datosInicio = new InicioSesion()
            {
                Correo = txtEmail.Text,
                Contraseña = txtContraseña.Text
            };

            //Convierto ajsonel objeto
            String json = JsonConvertidor.Objeto_Json(datosInicio);
            //Obtengo el JWT Solicitando la comunicación con el controlador
            peticion.PedirComunicacion("Usuario/PedirToken", MetodoHTTP.POST, TipoContenido.JSON);
            //Envio los datos al controlador contactado
            peticion.enviarDatos(json);
            //Obtengo el valor que regresa el controlador
            json = peticion.ObtenerJson();

            if (json != "null")
            {
                json = json.Substring(1, json.Length - 2);

                Session["jwt"] = json;

                peticion.PedirComunicacion("Usuario/VerificarToken/10", MetodoHTTP.GET, TipoContenido.JSON, json);
                json = peticion.ObtenerJson();

                peticion.PedirComunicacion("Usuario/ConsultarPorUsuario", MetodoHTTP.GET, TipoContenido.JSON, Session["jwt"].ToString());
                json = peticion.ObtenerJson();

                UsuarioDTO usuario = JsonConvertidor.Json_ListaObjeto<UsuarioDTO>(json).FirstOrDefault();

                Session["UsuarioActivo"] = usuario.Nombre;

                Response.RedirectToRoute("Menu");
            }
            else
            {
                //< link href = "../Estilos/Men.css" rel = "stylesheet" />
                ScriptManager.RegisterStartupScript(this, typeof(Page), "InicioSesion", InicioSesion, false);
            }
        }
    }
}