using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ingrese porfavor el numero de camisas que desea comprar: ");
            int num = int.Parse(Console.ReadLine());
            System.Console.Write("Ingrese porfavor el valor de las camisas que desea comprar: ");
            int precio = int.Parse(Console.ReadLine());
            precio = precio * num;
            if (num >= 3)
                System.Console.WriteLine($"El total a pagar con un descuento del 20% es: {precio - (precio * 0.2)}");
            else if (num >= 1 && num < 3)
                System.Console.WriteLine($"El total a pagar con un descuento del 10% es: {precio - (precio * 0.1)}");
            else
                System.Console.WriteLine("Porfavor ingrese un numero de camisas valido.");
        }
    }
}
