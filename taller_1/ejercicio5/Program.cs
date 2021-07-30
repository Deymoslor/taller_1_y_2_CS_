using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, tiempo;

            Console.WriteLine("Ingrese la distancia en KiloMetros recorrida por el coche:");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo en horas que le tomo al coche recorrer el trayecto:");
            tiempo = double.Parse(Console.ReadLine());

            Console.WriteLine($"La velocidad alcanzada durante el trayecto fue de: {distancia / tiempo} Km/H");
        }
    }
}
