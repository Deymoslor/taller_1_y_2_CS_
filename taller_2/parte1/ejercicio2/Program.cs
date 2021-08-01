using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 10)
            {
                int triple = num * 3;
                Console.WriteLine($"El triple del numero ingresado es: {triple}");
            }
            else
            {
                Console.WriteLine($"El numero ingresado es: {num}");
            }
                

        }
    }
}
