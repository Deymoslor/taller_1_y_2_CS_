using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el numero 1: ");
            Double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite el numero 2: ");
            Double num2 = Double.Parse(Console.ReadLine());
            if(num1 > num2)
                Console.WriteLine($"La suma de los numeros es: {num1+num2}");
        }
    }
}
