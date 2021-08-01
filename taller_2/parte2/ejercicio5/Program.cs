using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la distancia en kilometros de su viaje: ");
            Double distancia = Double.Parse(Console.ReadLine());
            Double precioInicial = 150*distancia;
            if(distancia > 1000)
                Console.Write($"El precio de ida y vuelta de su pasaje es de {precioInicial-(precioInicial*0.3)}");
            else
                Console.Write($"El precio de ida y vuelta de su pasaje es de {precioInicial}");
        }
    }
}
