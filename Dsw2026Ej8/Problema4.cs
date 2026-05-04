using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public  class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notas = new[] { nota1, nota2, nota3 };

           
            var validas = notas
                .Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10)
                .Select(n => n!.Value)
                .ToList();

            if (!validas.Any())
                return 0;

            return validas.Average();
        }
    }
}
