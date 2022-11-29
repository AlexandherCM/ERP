using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Remision")]

    public class Remision
    {
        [Key]
        public String ID { get; set; }
        public String Folio { get; set; }
        public virtual CotizacionVenta CotizacionVenta { get; set; }
        public String Responsable { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CotizacionVenta_Folio { get; set; }
        public string CotizacionVentas_Folio { get; set; }
        public string Factura_FolioFac { get; set; }
        public String Imagen { get; set; }

        public virtual CotizacionVenta CotizacionVentas { get; set; }
        public virtual Factura Factura { get; set; }
    }

    public class RemisionDTO
    {
        public String ID { get; set; }
        public String Folio { get; set; }
        public virtual CotizacionVenta CotizacionVenta { get; set; }
        public String Responsable { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CotizacionVenta_Folio { get; set; }
        public string CotizacionVentas_Folio { get; set; }
        public string Factura_FolioFac { get; set; }
        public String Imagen { get; set; }
    }
}