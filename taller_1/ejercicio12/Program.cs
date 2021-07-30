using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de hombres: ");
            int hombres = int.Parse(Console.ReadLine());
            Console.Write("Digite la cantidad de mujeres: ");
            int mujeres = int.Parse(Console.ReadLine());
            int total=hombres+mujeres;
            Console.Write($"El porcentaje de hombres es de: {(hombres*100)/total}% \n El porcentaje de mujeres es de: {(mujeres*100)/total}%");
        }
    }
}
