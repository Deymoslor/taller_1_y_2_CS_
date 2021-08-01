using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de cuadernos que desea comprar");
            int cuadernos = int.Parse(Console.ReadLine());
            if (cuadernos >= 5)
            {
                Console.WriteLine("Cada cuaderno vale 2,000$");
                Console.Write($"\nEn total debera pagar: {(cuadernos*2000)}.\n");
            }else
            {
                Console.WriteLine("Cada cuaderno vale 2,500$");
                Console.Write($"\nEn total debera pagar: {(cuadernos*2500)}.\n");
            }
        }
    }
}
