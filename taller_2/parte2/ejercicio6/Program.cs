using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Porfavor ingrese el salario de el empleado: ");
            double salarioBase = double.Parse(Console.ReadLine());
            if (salarioBase >= 2000000)
                System.Console.WriteLine($"El salario final de el empleado es de: ${salarioBase - (salarioBase * 0.1)}");
            else if (salarioBase < 2000000)
                System.Console.WriteLine($"El salario final de el empleado es de: ${salarioBase - (salarioBase * 0.03)}");
        }
    }
}
