using AGCComercial.Models;
using ProyectoAGC.Models; //Adaptar la redirección de ser necesario
using ERP_Comercial.ProcesoJWT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP_Comercial.Controllers
{
    public class UsuarioController : ApiController
    {
        Modelo bd = new Modelo();

        //- - - - - - - Controlador para agregar usuario a la base de datos - - - - - - - - - - - //

        [JWT]
        [ActionName("AgregarUsuario")]
        [HttpPost]

        public bool AgregarUsuario(Usuario usuario)
        {
            var NewUser = bd.Usuario.Where(c =>c.UsuarioID == usuario.UsuarioID && c.UserName == usuario.UserName && c.Correo == usuario.Correo && c.Contraseña == usuario.Contraseña).FirstOrDefault();

            try
            {
                if (NewUser == null)
                {
                    bd.Usuario.Add(usuario);
                    bd.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        //- - - - - - - Controlador para mostrar un Usuario de la base de datos - - - - - - - //

        [JWT]
        [ActionName("MostrarUsuario")]
        [HttpGet]

        public IQueryable<UsuarioDTO> Get(String id)
        {
            IQueryable<UsuarioDTO> Consulta = from consulta in bd.Usuario
                                                   where consulta.UsuarioID == id
                                                   select new UsuarioDTO
                                                   {
                                                       UsuarioID = consulta.UsuarioID,
                                                       Nombre = consulta.Nombre,
                                                       UserName = consulta.UserName,
                                                       Correo = consulta.Correo,
                                                       Contraseña = consulta.Contraseña
                                                   };
            return Consulta;
        }

        //- - - - - - - Controlador para mostrar Usuarios de la base de datos - - - - - - - //

        [JWT]
        [ActionName("MostrarUsuarios")]
        [HttpGet]

        public IQueryable<UsuarioDTO> Get()
        {
            IQueryable<UsuarioDTO> Consulta = from consulta in bd.Usuario
                                                   select new UsuarioDTO
                                                   {
                                                       UsuarioID = consulta.UsuarioID,
                                                       Nombre = consulta.Nombre,
                                                       UserName = consulta.UserName,
                                                       Correo = consulta.Correo,
                                                       Contraseña = consulta.Contraseña
                                                   };
            return Consulta;
        }

        //- - - - - - - Controlador para Actualizar Usuario de la base de datos - - - - - - - //

        [JWT]
        [ActionName("ActualizarUsuario")]
        [HttpPut]

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                bd.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //- - - - - - - Controlador para eliminar usuario de la base de datos - - - - - - - //

        [JWT]
        [ActionName("BorrarUsuario")]
        [HttpDelete]

        public bool BorrarUsuario(String id)
        {
            try
            {
                Usuario usuario = bd.Usuario.Find(id);
                bd.Entry(usuario).State = System.Data.Entity.EntityState.Deleted;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // - - - - - - - - - - - - - - - - - Clases y Controladores JWT - - - - - - - - - - - - - - - - - - //

        CrearJWT jwt = new CrearJWT();

        // - - - - - - - - - - - - - - - - - - Controlador que crea JWT - - - - - - - - - - - - - - - - - - //

        [ActionName("PedirToken")]
        [HttpPost]

        public String PedirToken(InicioSesion DatosInicio)
        {
            var UsuarioID = bd.Usuario.Where(c => c.Correo == DatosInicio.Correo && c.Contraseña == DatosInicio.Contraseña).FirstOrDefault();

            if (UsuarioID != null)
            {
                DateTime expira;

                expira = DateTime.Now.AddMinutes(.25);
                Epoch epoch = new Epoch();

                Dictionary<string, object> payload = new Dictionary<string, object>()
                {
                    {"Sub", UsuarioID.UsuarioID},
                    {"Exp", epoch.convertirEpoch(expira)},
                    {"Nbf", epoch.convertirEpoch(DateTime.Now)}
                };

                return jwt.GetJWT(payload);
            }
            else
            {
                return null;
            }
        }

        // - - - - - - - - - - - - - - - - - - Controlador que consulta JWT - - - - - - - - - - - - - - - - - - //

        [JWT]
        [ActionName("ConsultarPorUsuario")]
        [HttpGet]
        public IQueryable<UsuarioDTO> ConsultarPorUsuario()
        {
            JSONwt usuarioJwt = JsonConvert.DeserializeObject<JSONwt>(Request.Properties["payload"].ToString());

            var usuarios = from consulta in bd.Usuario
                           where consulta.UsuarioID == usuarioJwt.Sub
                           select new UsuarioDTO
                           {
                               UsuarioID = consulta.UsuarioID,
                               Nombre = consulta.Nombre,
                               UserName = consulta.UserName,
                               Correo = consulta.Correo,
                               Contraseña = consulta.Contraseña
                           };

            return usuarios;
        }

        // - - - - - - - - - - - - - - - - - - Controlador que verifica JWT - - - - - - - - - - - - - - - - - - //

        [JWT]
        [ActionName("VerificarToken")]
        [HttpGet]
        public JSONwt VerificarToken()
        {
            JSONwt usuarioJwt = JsonConvert.DeserializeObject<JSONwt>(Request.Properties["payload"].ToString());

            return usuarioJwt;
        }

        // - - - - - - - - - - - - - - - - - - Controladores de testeo - - - - - - - - - - - - - - - - - - - - - //
        [JWT]
        [ActionName("Expirar")]
        [HttpGet]
        public String boton()
        {
            return "Sesión activa :)";
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //




    }
}
