using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.Write($"\nUsted tiene {edad}, por lo cual es mayor de edad.\n");
            else
                Console.Write($"\nUsted tiene {edad}, por lo cual es menor de edad.\n");
        }
    }
}
