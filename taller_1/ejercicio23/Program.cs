using System;

namespace ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad de metros que decea subir: ");
            float mm = float.Parse(Console.ReadLine());
            float hh = (float)0.714285714286;
            float mh = mm * hh;
            Console.WriteLine("El tiempo que tardarà es: " + mh + " horas");
        }
    }
}
