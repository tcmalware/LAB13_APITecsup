using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models.Request
{
    public class ProductoRequest
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double IGV { get; set; }
    }
}