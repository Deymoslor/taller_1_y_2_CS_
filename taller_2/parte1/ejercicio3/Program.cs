using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio de la computadora que desea comprar: ");
            double p = double.Parse(Console.ReadLine());
            if (p > 1000000.0)
            {
                p = p - (p * 0.1);
                Console.WriteLine("Descuento del 10%: " + p);
            }
            Console.WriteLine("");
            p = p + (p * 0.19);
            Console.WriteLine("Precio TOTAL con IVA incluido: ");
            Console.WriteLine("");
        }
    }
}
