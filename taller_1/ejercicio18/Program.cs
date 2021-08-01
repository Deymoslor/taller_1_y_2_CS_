using System;

namespace ejercicio18
{
    class Program
    {
       static void Main(string[] args)
        {
            decimal valor, primera, segunda, tercera, cuarta;

            Console.Write("Ingrese el valor de la mátricula: ");
            valor = decimal.Parse(Console.ReadLine());

            primera = valor * 0.40m;
            segunda = valor * 0.25m;
            tercera = valor * 0.20m;
            cuarta = valor * 0.15m;

            Console.Write($"\nLas cuotas que deben pagar el estudiante son:\n  - Primera cuota (40%): ${primera.ToString("N0")}\n  - segunda cuota (25%): ${segunda.ToString("N0")}\n  - Tercera cuota (20%): ${tercera.ToString("N0")}\n  - Cuarta cuota (15%): ${cuarta.ToString("N0")}\n  **El valor a pagar es de ${valor.ToString("N0")}**");
        }
    }
}
