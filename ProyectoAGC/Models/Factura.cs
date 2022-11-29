using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Factura")]

    public class Factura
    {
        [Key]
        public String ID { get; set; }

        public String FolioRemision { get; set; }
        public float PrecioUni { get; set; }
        public float Importe { get; set; }
        public float Subtotal { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public DateTime FechaHora { get; set; }
        public String MetodoPago { get; set; }
        public String FormaPago { get; set; }

        public virtual List<Remision> Remisiones { get; set; }
    }

    public class FacturaDTO
    {
        public String ID { get; set; }
        public String FolioRemision { get; set; }
        public float PrecioUni { get; set; }
        public float Importe { get; set; }
        public float Subtotal { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public DateTime FechaHora { get; set; }
        public String MetodoPago { get; set; }
        public String FormaPago { get; set; }
    }
}