using System;

namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno;
            String nombre, direccion;

            Console.Write("Ingrese porfavor su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese porfavor la direccion de su residencia: ");
            direccion = Console.ReadLine();

            Console.Write("Ingrese porfavor el año de su nacimiento: ");
            anno = int.Parse(Console.ReadLine());

            Console.WriteLine($"Buenas { nombre }, su direccion es [{ direccion }] con edad de { 2021 - anno } años");
        }
    }
}
