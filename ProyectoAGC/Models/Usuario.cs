using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Usuario")]

    public class Usuario
    {
        [Key]
        public String UsuarioID { get; set; }

        public String Nombre { get; set; }
        public String UserName { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }
        
        public virtual List<Pedido> Pedidos { get; set; }
        public virtual List<CotizacionVenta> CotizacionVentas { get; set; }
    }

    public class UsuarioDTO
    {
        public String UsuarioID { get; set; }
        public String Nombre { get; set; }
        public String UserName { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }
    }
}