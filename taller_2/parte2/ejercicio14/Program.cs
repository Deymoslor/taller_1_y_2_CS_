using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ingrese porfavor un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                double elevado = Math.Pow(num, 2);
                System.Console.WriteLine("El numero es par: " + elevado);
            }
            else if (num % 2 == 1)
            {
                System.Console.WriteLine("El numero es impar: " + num * 3);
            }
        }
    }
}
