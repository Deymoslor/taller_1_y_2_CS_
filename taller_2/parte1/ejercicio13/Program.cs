using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------COMPRA DE COMPUTADORAS----------");
            Console.WriteLine("Recuerde que por compra iguales o mayores a $1.000.000 se tendra un descuento del 10%.");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.Write("Ingrese el costo total de la computadora: ");
            double total = double.Parse(Console.ReadLine());

            if (total >= 1000000)
                Console.WriteLine($"El total a pagar con descuento y iva del 19% es de: {total - (total * 0.1) + (total * 0.19)}");
            else
                Console.WriteLine($"El total a pagar con iva del 19% es de: {total + (total * 0.19)}");
        }
    }
}
