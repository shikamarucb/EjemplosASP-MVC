using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Funciones_especiales_del_DbContext_EF.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int CodigoProducto { get; set; }
        public decimal Valor { get; set; }
    }
}