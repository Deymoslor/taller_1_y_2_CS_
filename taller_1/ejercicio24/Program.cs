using System;

namespace ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el valor del prestamo: ");
            Double prestamo = Double.Parse(Console.ReadLine());
            Double interesAnual = prestamo*0.05;
            Double interesMensual = interesAnual / 12;
            Double InteresTercerTrimestre = interesMensual * 9;
            Double mesSinIntereses = prestamo / 12;
            Double mesConIntereses = mesSinIntereses + interesMensual;
            Double totalPagar = (mesConIntereses*12)*5;
            Console.Write($"El dinero que se ha pagado de intereses en un año es de: {interesAnual} \n El dinero que se ha pagado de intereses en el tercer trimestre del año es de: {InteresTercerTrimestre} \n El dinero que se ha pagado de intereses en el primer año es de: {interesMensual} \n El dinero que se ha pagado en total es de: {totalPagar}");
        }
    }
}
