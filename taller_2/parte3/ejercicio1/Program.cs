using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;
            Console.Write("Ingrese por favor un numero:");
            numero = int.Parse(Console.ReadLine());

            metodoCiclo(numero);


        }

        public static void metodoCiclo(int numero)
        {
            int s, cont = 0;
            bool pri;
            for (int j = 1; j <= numero; j++)
            {
                pri = true;
                s = 2;
                while (s <= j - 1 && pri == true)
                {
                    if (j % s == 0)
                    {
                        pri = false;
                    }
                    s++;
                }

                if (pri == true)
                {
                    Console.WriteLine("Encontrado primo en " + j);
                    cont += 1;
                }
            }
            Console.WriteLine("Numero de primos encontrados: " + cont);
        }
    }
}
