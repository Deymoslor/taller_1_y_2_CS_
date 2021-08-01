using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 10)
                Console.Write($"\nEl triple de el número ingresado es: {num*3}.\n");
            else
                Console.Write($"\nLa cuarta parte de el número ingresado es: {num / 4}.\n");
        }
    }
}
