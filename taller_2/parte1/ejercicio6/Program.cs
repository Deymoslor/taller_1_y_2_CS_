using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBruto, salario, retencion;

            Console.Write("Ingrese el salario del empleado: ");
            salarioBruto = decimal.Parse(Console.ReadLine());

            if (salarioBruto > 2000000)
            {
                retencion = salarioBruto * 0.10m;
                salario = salarioBruto - retencion;

                Console.Write($"\nSu salario bruto es de ${salarioBruto.ToString("N0")} , el cual supera los $2.000.000, por lo cual tiene una retención de ${retencion.ToString("N0")}.\nSu salario final es ${salario.ToString("N0")}.\n");
            }
            else
            {
                salario = salarioBruto;
                Console.WriteLine($"Su salario es ${salario.ToString("N0")}");
            }
        }
    }
}
