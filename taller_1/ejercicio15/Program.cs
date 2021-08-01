using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            double tt = 0, tta = 0;
            String pregunta;
            do
            {
                Console.WriteLine("Ingrese el precio del producto: ");
                tt = double.Parse(Console.ReadLine());
                Console.WriteLine("¿Quieres volver a ingresar? R// ");
                pregunta = Console.ReadLine();
                tta = tta + tt;
            } while (pregunta.Equals("si"));
            tta = (tta * 0.19) + tta;
            Console.WriteLine("");
            Console.WriteLine("El total a pagar: " + tta);
            Console.WriteLine("");
            Console.WriteLine("Ingrese el dinero en efectivo: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Su cambio es: " + (tta - r));
            Console.WriteLine("");
        }
    }
}
