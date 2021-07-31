using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, suma, resta, multiplicacion, division;

            Console.Write("Ingrese número 1: ");
            num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            num2 = decimal.Parse(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;

            Console.Write($"\nEl número 1 es: {num1} y el número 2 es: {num2}.\n\nLa suma de los dos números es: {suma}.\nLa resta de los dos números es: {resta}.\nLa multiplicación de los dos números es: {multiplicacion}.\nLa división de los dos números es: {division}.\n");
        }
    }
}
