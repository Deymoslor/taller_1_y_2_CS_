using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota: ");
            float n3 = float.Parse(Console.ReadLine());
            float nt = (n1 + n2 + n3) / 3;
            Console.WriteLine("La nota definitiva es: " + nt);
            Console.WriteLine("");
        }
    }
}
