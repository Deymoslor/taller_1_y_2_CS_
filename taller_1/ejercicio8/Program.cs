using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad a invertir: ");
            Double inversion = Double.Parse(Console.Read());
            Console.Write($"La ganancia que obtendría al cabo de un mes es de{inversion+(inversion*0.02)}");
        }
    }
}
