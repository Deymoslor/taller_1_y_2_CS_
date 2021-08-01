using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad invertida: ");
            Double cantidad = Double.Parse(Console.ReadLine());
            Console.Write("Digite la tasa de interés: ");
            Double tasa = Double.Parse(Console.ReadLine());
            Double interes = cantidad * tasa;

            if (interes > 7000)
                Console.WriteLine($"Los intereses generados por la inversión fueron: {interes}, supera los 7.000");
            else
                Console.WriteLine($"Los intereses generados por la inversión fueron: {interes}, no supera los 7.000");
            Console.WriteLine($"El dinero final de su cuenta es: {cantidad+interes}");
        }
    }
}
