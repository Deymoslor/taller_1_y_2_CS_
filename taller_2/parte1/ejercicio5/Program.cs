using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el total a pagar: ");
            double totalPagar = Double.Parse(Console.ReadLine());

            if (totalPagar >= 100000)
                Console.WriteLine($"El total a pagar es de: {  totalPagar - (totalPagar * 0.2)}");
            else
                Console.WriteLine($"El total a pagar es de: { totalPagar }");
        }
    }
}
