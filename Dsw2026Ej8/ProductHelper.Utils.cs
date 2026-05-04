using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private const string CultureMoneda = "es-AR"; 

        private string FormatearPrecio(decimal price)
        {
            var cultura = new CultureInfo(CultureMoneda);
            return price.ToString("C", cultura);
        }
    }
}
