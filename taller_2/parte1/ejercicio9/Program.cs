using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Porfavor digite un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
                Console.Write($"El numero {num} SI es multiplo de 5.");
            else
                Console.Write($"El numero {num} NO es multiplo de 5.");
        }
    }
}
