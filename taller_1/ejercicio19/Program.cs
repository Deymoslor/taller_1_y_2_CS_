using System;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre: ");
            String name = Console.ReadLine();
            Console.WriteLine("Ingrese su programa de formaciòn: ");
            String formacion = Console.ReadLine();
            Console.WriteLine("Ingrese su ficha de formaciòn: ");
            String ficha = Console.ReadLine();
            Console.WriteLine("Ingrese la nota: ");
            double nn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn5 = double.Parse(Console.ReadLine());
            double nnt = ((nn1 + nn2 + nn3 + nn4 + nn5) / 5);
            Console.WriteLine("");
            Console.WriteLine("NOMBRE:                " + name);
            Console.WriteLine("PROGRAMA DE FORMACIÒN: " + formacion);
            Console.WriteLine("FICHA DE FORMACIÒN:    " + ficha);
            Console.WriteLine("NOTA FINAL:            " + nnt);
            Console.WriteLine("");
        }
    }
}
