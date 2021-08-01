using System;

namespace ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, litros;
            decimal  tiempo;

            Console.WriteLine("Menú");
            Console.WriteLine("  1. Saber el tiempo de llenado del balde.\n  2. Saber el tamaño del balde.\nIngrese la opción que desea: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el tamaño del balde en litros, los baldes disponibles son: 1 litro, 3 litros, 5 litros.");
                    litros = int.Parse(Console.ReadLine());

                    if ((litros ==1) || (litros == 3) || (litros == 5))
                    {
                        switch (litros)
                        {
                            case 1:
                                Console.Write($"El balde es de {litros} litros, el cual se llena en una hora y media.");
                                break;
                            case 3:
                                Console.Write($"El balde es de {litros} litros, el cual se llena en tres horas.");
                                break;
                            case 5:
                                Console.Write($"El balde es de {litros} litros, el cual se llena en cuatro horas y media.");
                                break;
                        }
                        
                    }
                    else
                    {
                        Console.Write("La selección que ha ingresado no es valida.");
                    }
                    break;
                case 2:
                    Console.Write("Ingrese la opción de tiempo en que se llena:\n 1.1.30\n 2. 3\n . 4.30:");
                    tiempo = decimal.Parse(Console.ReadLine());

                    switch (tiempo)
                    {
                        case 1:
                            Console.Write($"El balde es de un litro.");
                            break;
                        case 2:
                            Console.Write($"El balde es de  tres litros.");
                            break;
                        case 3:
                            Console.Write($"El balde es de  cinco litros.");
                            break;
                    }
                    break;
            }
        }
    }
}
