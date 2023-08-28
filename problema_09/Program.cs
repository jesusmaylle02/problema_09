using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tres números enteros:");

            // Leer tres números ingresados por el usuario
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            // Calcular el mayor de los tres números que ingreso el usuario 
            int mayor = Math.Max(Math.Max(numero1, numero2), numero3);
            Console.WriteLine($"El mayor de los tres números es: {mayor}");
            Console.ReadKey();
        }
    }
}
