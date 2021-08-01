using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            convertir dab = new convertir();
            Console.WriteLine("Ingrese un numero del 0 al 99: ");
            String pae = Console.ReadLine();
            String letras = dab.Convertir(pae, true);
            Console.WriteLine(letras);
        }
    }
}
