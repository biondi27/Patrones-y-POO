using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    public class Coche
    {
        public string? Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public void Arrancar()
        {
            Console.WriteLine("El vehículo ha arrancado.");
        }
    }
}
