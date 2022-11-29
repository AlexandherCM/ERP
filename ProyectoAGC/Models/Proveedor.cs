using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Proveedor")]

    public class Proveedor
    {
        [Key]
        public String ID { get; set; }
        public String Empresa { get; set; }
        public String RazonSocial { get; set; }
        public String Contacto { get; set; }
        public String Categoria { get; set; }
        public String Giro { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Zona { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }

    public class ProveedorDTO
    {
        public String ID { get; set; }
        public String Empresa { get; set; }
        public String RazonSocial { get; set; }
        public String Contacto { get; set; }
        public String Categoria { get; set; }
        public String Giro { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Zona { get; set; }
    }
}