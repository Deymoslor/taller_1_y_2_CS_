using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            double valorH, salario;

            Console.WriteLine("Ingrese porfavor las horas trabajadas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese porfavor el valor de la hora trabajada:");
            valorH = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su salario es: { salario = horas * valorH}");
        }
    }
}
