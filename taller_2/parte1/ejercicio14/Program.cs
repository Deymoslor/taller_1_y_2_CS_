using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese numero 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.Write($"\nEl Primer numero ingresado es: {num1}\nEl segungo numero es: {num2}\n\nLa suma de los dos es: {num1 + num2}\n");
        }
    }
}
