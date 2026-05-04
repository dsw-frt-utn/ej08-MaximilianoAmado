using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioFormateado = FormatearPrecio(price);
            return $"[{code}] {description} - {precioFormateado}";
        }
    }
}
