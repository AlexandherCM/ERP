using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("Pedido")]

    public class Pedido
    {
        [Key]
        public String PedidoID { get; set; }

        public String RFC { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public String IDProducto { get; set; }
        public virtual Producto Producto { get; set; }
        public String IDUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Total { get; set; }
        public long ClabeBancaria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }

    public class PedidoDTO
    {
        public String PedidoID { get; set; }
        public String RFC { get; set; }
        public String IDProducto { get; set; }
        public String IDUsuario { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Total { get; set; }
        public long ClabeBancaria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}