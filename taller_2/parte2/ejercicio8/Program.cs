using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double pull = 0;
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo (Si es mujer ingrese 1 y si es hombre ingrese 2)");
            int sexo = int.Parse(Console.ReadLine());
            if (sexo == 1)
            {
                pull = (220-edad)/10;
            }else if (sexo == 2)
            {
                pull = (210-edad)/10;
            }
            Console.WriteLine("La cantidad e pulsaciones que deberìas tener es: ",pull);
        }
    }
}
