using AGCComercial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;

namespace ProyectoAGC.Vistas.Paginas
{
    
    public partial class NuevoCliente : System.Web.UI.Page
    {
        PeticionHTTP peticionHTTP = new PeticionHTTP("http://localhost:50393");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarClient_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                ID = txtRFCClient.Text,
                Nombre = txtNom.Text,
                Direccion = txtDirecClient.Text,
                Telefono = txttelClient.Text,
                Correo = txtEmailClient.Text
            };

            String EnviarJSON = JsonConvertidor.Objeto_Json(cliente);
            peticionHTTP.PedirComunicacion("Clientes/CrearCliente", MetodoHTTP.POST, TipoContenido.JSON);
            peticionHTTP.enviarDatos(EnviarJSON);
            String RecibirJSON = peticionHTTP.ObtenerJson();
        }
    }
}