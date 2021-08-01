using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero: ");
            int cubo = 0;
            int c = int.Parse(Console.ReadLine());
            if (c >= 10)
            {
                cubo = c * c * c;
                Console.WriteLine("");
                Console.WriteLine("El cubo es: " + cubo);
            }
        }
    }
}
