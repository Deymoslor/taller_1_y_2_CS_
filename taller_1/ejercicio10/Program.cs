using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor, total,descuento;
            Console.Write("Ingrese el valor de la compra: ");
            valor = decimal.Parse(Console.ReadLine());
            descuento = valor * 0.15m;
            total = valor - descuento;

            Console.Write($"\nEl valor de su compra es de ${valor.ToString("N0")}, el cual tiene un descuento de ${descuento.ToString("N0")}; lo cual da un valor a pagar de ${total.ToString("N0")}.\n");

        }
    }
}
