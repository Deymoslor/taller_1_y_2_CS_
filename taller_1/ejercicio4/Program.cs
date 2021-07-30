using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite su nota #1 por favor: ");
            Double nota1=Double.Parse(Console.ReadLine());
            Console.Write("Digite su nota #2 por favor: ");
            Double nota2=Double.Parse(Console.ReadLine());
            Console.Write("Digite su nota #3 por favor: ");
            Double nota3=Double.Parse(Console.ReadLine());
            nota1 = nota1 * 0.2;
            nota2 = nota2 * 0.3;
            nota3 = nota3 * 0.5;
            Double promedio = nota1+nota2+nota3;
            Console.WriteLine($"La definitiva de la asignatura es: {promedio}");
        }
    }
}
