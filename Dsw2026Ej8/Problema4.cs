using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int cantidad = 0;

            foreach (int? nota in new[] { nota1, nota2, nota3 })
            {
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    cantidad++;
                }
            }

            return cantidad == 0 ? 0 : suma / cantidad;
        }
    }
}
