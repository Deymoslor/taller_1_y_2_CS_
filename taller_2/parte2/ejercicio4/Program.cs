using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Numeros: ",a," , ",b);
            }else
            {
                Console.WriteLine("Numeros: ",b," , ",a);
            }
        }
    }
}
