using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Program
    {
        static Icalculator icalculator;
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la opción");
            Console.WriteLine("Opción 1: Suma");
            Console.WriteLine("Opción 2: Resta");
            Console.WriteLine("Opción 3: Multiplicación");
            Console.WriteLine("Opción 4: División");

            string _opcion = Console.ReadLine();
            Console.WriteLine("Escriba el primer valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            icalculator = Factory.Get_operaciones(_opcion);
            icalculator.calcular(valor1, valor2);
            Console.ReadKey();
        }
    }
}