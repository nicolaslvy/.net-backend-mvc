using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace wSpunto_de_venta.Models
{
    public partial class Concepto
    {
        public long Id { get; set; }
        public long? IdVenta { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Preciounitario { get; set; }
        public decimal? Importe { get; set; }
        public int? IdProducto { get; set; }
    }
}
