using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ingrese porfavor 'D' para dormido o 'A' para acostado, para saber su actividad: ");
            char opt = char.Parse(Console.ReadLine());
            System.Console.Write("Ingrese el numero de minutos que realizo esta actividad: ");
            int numMins = int.Parse(Console.ReadLine());
            if (opt == 'D')
                System.Console.WriteLine($"La cantidad de calorias consumidas en {numMins} minutos es de: {1.08 * numMins }");
            else if (opt == 'A')
                System.Console.WriteLine($"La cantidad de calorias consumidas en {numMins} minutos es de: { 1.66 * numMins }");
            else
                System.Console.WriteLine("Opciones incorrectas.");
        }
    }
}
