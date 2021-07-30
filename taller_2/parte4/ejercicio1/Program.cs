using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int s, cont = 0, pri = 1;
            System.Console.Write("Ingrese por favor un numero:");
            numero = int.Parse(Console.ReadLine());
            for (int j = 1; j <= numero; j++)
            {
                pri = 1;
                if (pri == 1)
                {
                    for (s = 2; s <= j - 1; s++)
                    {
                        if (j % s == 0)
                        {
                            pri = 0;
                        }
                    }
                }
                switch (pri)
                {
                    case 1:
                        System.Console.WriteLine("Encontrado primo en " + j);
                        cont += 1;
                        break;
                    default:
                        System.Console.WriteLine("Buscando...");
                        break;
                }
            }
            System.Console.WriteLine("Numero de primos encontrados: " + cont);
        }
    }
}
