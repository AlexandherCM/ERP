using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Producto")]

    public class Producto
    {
        [Key]
        public String ProductoID { get; set; }

        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public float Precio { get; set; }
        public String Categoria { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
        public virtual List<CotizacionVenta> CotizacionVentas { get; set; }
    }

    public class ProductoDTO
    {
        public String ProductoID { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public float Precio { get; set; }
        public String Categoria { get; set; }
    }
}