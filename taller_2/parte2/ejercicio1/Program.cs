using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el nombre del articulo: ");
            String nombre = Console.ReadLine();
            Console.Write("¿Cual es la clave del artículo? 01 / 02: ");
            String clave = Console.ReadLine();
            Console.Write("¿Cual es el precio del articulo?: ");
            Double precio = Double.Parse(Console.ReadLine());
            if(clave == "01")
                Console.Write($"El producto '{nombre}', con clave '{clave}', con un precio inicial de, '{precio}', con descuento del 10% quedaría en un total de: {precio-(precio*0.1)}");
            else if (clave == "02")
                Console.Write($"El producto '{nombre}', con clave '{clave}', con un precio inicial de, '{precio}', con descuento del 20% quedaría en un total de: {precio-(precio*0.2)}");
            else
                Console.Write("Esa clave de artículo no existe, limítese a utilizar 01 / 02");
        }
    }
}
