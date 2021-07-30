using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Porfavor ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
                Console.WriteLine("Numero par!");
            else
                Console.WriteLine("Numero impar!");
        }
    }
}
