using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    public class Vehículo : Coche
    {
        public int NumeroPuertas { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("El coche está acelerando.");
        }
    }
}
