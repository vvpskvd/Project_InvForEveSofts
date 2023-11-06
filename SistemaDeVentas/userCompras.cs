using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class userCompras
    {
        private int CodigoCompra;
        private string? name;
        private int precio;
        private string? proveedor;

        public int Codigo { get => CodigoCompra; set => CodigoCompra = value; }
        public string? Name { get => name; set => name = value; }
        public int Precio { get => precio; set => precio = value; }
        public string? Proveedor { get => proveedor; set => proveedor = value; }
    }
}
