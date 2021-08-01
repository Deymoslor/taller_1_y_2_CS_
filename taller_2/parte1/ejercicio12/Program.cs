using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite su estatura en cm: ");
            Double estatura = Double.Parse(Console.ReadLine());
            if(estatura > 1.70)
                Console.WriteLine("Usted es alto");
        }
    }
}
