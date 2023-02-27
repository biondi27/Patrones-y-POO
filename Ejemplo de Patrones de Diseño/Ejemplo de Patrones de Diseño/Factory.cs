using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class Factory
    {
        static Icalculator icalculator;
        public static Icalculator Get_operaciones(string _opcion)
        {
            switch (_opcion)
            {
                case "1":
                    icalculator = new Suma();
                    break;

                case "2":
                    icalculator = new Resta();
                    break;

                case "3":
                    icalculator = new Multiplicación();
                    break;

                case "4":
                    icalculator = new División();
                    break;
            }
            return icalculator;
        }
    }
}
