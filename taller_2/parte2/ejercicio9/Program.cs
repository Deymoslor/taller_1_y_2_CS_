using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de horas trabajadas en la semana: ");
            int horas = int.Parse(Console.ReadLine());
            if(horas <= 40)
                Console.Write($"Su sueldo semanal es de: {(horas*10000)}");
            else if(horas > 40){
                int horasExtra = horas - 40;
                Double salarioFinal=(horas*10000)+(horasExtra*15000);
                Console.Write($"Su sueldo semanal es de: {salarioFinal}");
            }else
                Console.Write("Limítese a digitar numeros positivos");
        }
    }
}
