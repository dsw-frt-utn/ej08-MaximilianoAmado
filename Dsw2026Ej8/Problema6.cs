using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }
            return code.ToProductCode();
        }
    }

    public static class Extensions
    {
 
        public static string ToProductCode(this string code)
        { 
            string resultado = code.Trim();

            resultado = resultado.ToUpper();

            while (resultado.Contains("  "))
            {
                resultado = resultado.Replace("  ", " ");
            }

            resultado = resultado.Replace(' ', '-');

            return resultado;
        }
    }
}