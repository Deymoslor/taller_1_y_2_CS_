using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            if ((num % 2) == 0)
                Console.Write("\nEl número ingresado es par.\n");
            else
                Console.Write("\nEl número ingresado es impar.\n");
        }
    }
}
