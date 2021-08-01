using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int hora, minuto, segundo;
            Console.WriteLine("Ingrese la hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos: ");
            minuto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos: ");
            segundo = int.Parse(Console.ReadLine());
            hora = hora * 60;
            minuto = (minuto * 60) + (hora * 60);
            segundo = segundo + minuto;
            Console.WriteLine("");
            Console.WriteLine("El total de segundos son: " + segundo + "s");
            Console.WriteLine("");
        }
    }
}
