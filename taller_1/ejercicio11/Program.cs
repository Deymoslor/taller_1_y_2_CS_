using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen final: ");
            float ef = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del trabajo final: ");
            float tf = float.Parse(Console.ReadLine());
            double npf = ((nota1 + nota2 + nota3) / 3) * 0.55;
            double etf = ef * 0.3;
            double ttf = tf * 0.15;
            Console.WriteLine("Su nota final es: " + (npf + etf + ttf));
            Console.WriteLine("");
        }
    }
}
