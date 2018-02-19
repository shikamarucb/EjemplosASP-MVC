using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insertando_registros_con_Entity_Framework.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int CodigoProducto { get; set; }
        public decimal Valor { get; set; }
    }
}