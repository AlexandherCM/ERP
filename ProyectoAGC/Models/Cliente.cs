using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Cliente")]

    public class Cliente
    {
        [Key]
        public String ID { get; set; }

        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }

        public virtual List<CotizacionVenta> CotizacionVentas { get; set; }
    }

    public class ClienteDTO
    {
        public string ID { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }
    }
}