using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehículo mivehículo = new Vehículo();
            mivehículo.Marca = "Toyota";
            mivehículo.Modelo = "Corolla";
            mivehículo.Año = 2022;
            mivehículo.NumeroPuertas = 4;
            mivehículo.Arrancar();
            mivehículo.Acelerar();

            Console.ReadKey();
            
            //Console.WriteLine("Elija la opción");
            //Console.WriteLine("Opción 1: Crear un coche");
            //Console.WriteLine("Opción 2: Ingresar un coche al garaje");
            //Console.WriteLine("Opción 3: Ver totales");

            //string _opcion = Console.ReadLine();
            //Console.WriteLine("Escriba el primer valor: ");
            //int litros_de_aceite = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escriba el segundo valor: ");
            //int potencias = Convert.ToInt32(Console.ReadLine());

            //reparaciones = Factory.Get_operaciones(_opcion);
            //reparaciones.calcular(litros_de_aceite, potencias);
            //Console.ReadKey();
        }
    }
}