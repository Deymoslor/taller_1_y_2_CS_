using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Es un numero negativo");
            }
            Console.WriteLine("");
        }
    }
}
