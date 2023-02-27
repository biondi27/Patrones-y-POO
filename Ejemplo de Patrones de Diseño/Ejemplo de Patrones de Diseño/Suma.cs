using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Suma : Icalculator
    {
        public void calcular(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            Console.WriteLine(resultado);
        }
    }
}