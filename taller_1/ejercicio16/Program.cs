using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el total recaudado: ");
            Double recaudado = Double.Parse(Console.ReadLine());
            Console.Write($"El valor que le corresponde por el dia de trabajo es de {recaudado*0.19}");
        }
    }
}
