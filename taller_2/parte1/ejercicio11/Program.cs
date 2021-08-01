using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese la nota 1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4: ");
            double b4 = double.Parse(Console.ReadLine());
            double pro = ((b1 + b2 + b3 + b4) / 4);
            if (pro < 3.5)
            {
                Console.WriteLine("Reprobò");
            }
            else
            {
                Console.WriteLine("Aprobò");
            }
            Console.WriteLine("");
        }
    }
}
