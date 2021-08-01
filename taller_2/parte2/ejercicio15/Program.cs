using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor;

            Console.Write("Ingrese valor de comprea: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor >= 200000)
                Console.Write($"\nEl descuento de su compra es de : ${(valor *0.17m).ToString("N0")} para un total de ${(valor-(valor * 0.17m)).ToString("N0")}");
            else
                Console.Write($"\nEl descuento de su compra es de : ${(valor * 0.05m).ToString("N0")} para un total de ${(valor - (valor * 0.17m)).ToString("N0")}");
        }
    }
}
