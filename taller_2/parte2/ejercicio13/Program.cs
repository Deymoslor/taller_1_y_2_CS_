using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el valor de la vivienda");
            Double valorVivienda = Double.Parse(Console.ReadLine());
            Console.Write("Digite sus ingresos mensuales");
            Double ingresosMensuales = Double.Parse(Console.ReadLine());
            if(ingresosMensuales >= 1200000){
                Double cuotaInicial = valorVivienda*0.15;
                Double resto = valorVivienda-cuotaInicial;
                Double valorCuotas = resto/120;
                Double valorFinalCuotas = valorCuotas+(valorCuotas*0.02);
                Console.Write($"El valor de la cuota inicial es de {cuotaInicial}, el valor de las siguientes 120 cuotas con una tasa del 2% es de {valorFinalCuotas}");
            }else if(ingresosMensuales < 1200000){
                Double cuotaInicial = valorVivienda*0.3;
                Double resto = valorVivienda-cuotaInicial;
                Double valorCuotas = resto/84;
                Double valorFinalCuotas = valorCuotas+(valorCuotas*0.01);
                Console.Write($"El valor de la cuota inicial es de {cuotaInicial}, el valor de las siguientes 120 cuotas con una tasa del 2% es de {valorFinalCuotas}");
            }else
                Console.Write("Limítese a utilizar valores positivos por favor.");
        }
    }
}
