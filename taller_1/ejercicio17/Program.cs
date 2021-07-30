using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioE, ahorroM, eps, fondoP;

            Console.WriteLine("Ingrese porfavor el salario del empleado: ");
            salarioE = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese porfavor el ahorro mensual programado del empleado: ");
            ahorroM = double.Parse(Console.ReadLine());
            eps = salarioE * 0.125;
            fondoP = salarioE * 0.16;

            Console.WriteLine("----------- COLILLA DE PAGO -----------");
            Console.WriteLine("Salario Base: " + salarioE + "\n");
            Console.WriteLine("Valor de Ahorro mensual: " + ahorroM + "\n");
            Console.WriteLine("El total para el aporte de la salud es de: " + eps + "\n");
            Console.WriteLine("El total para el aporte para el fondo de pensiones: " + fondoP + "\n");

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------" + "\n");
            Console.WriteLine("El total del pago es de: $" + (((salarioE - ahorroM) - eps) - fondoP));
            Console.WriteLine("FIN");
        }
    }
}
