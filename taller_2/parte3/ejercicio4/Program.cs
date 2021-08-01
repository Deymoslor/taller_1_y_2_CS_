using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            String continuar = "";
            Console.WriteLine("Porfavor digite (Cero) 0 para finalizar el programa.");
            while (continuar!="0"){
                Console.Write("Porfavor digite una letra del abecedario para saber si es vocal o consonante: ");
                String resp = Console.ReadLine();
                if (resp=="0")
                    continuar = "0";
                else
                    Letra(resp);
                
            }
        
        }
        static private void Letra (String letra){
            if(letra.Equals("a",StringComparison.InvariantCultureIgnoreCase) || letra.Equals("e",StringComparison.InvariantCultureIgnoreCase) || letra.Equals("i",StringComparison.InvariantCultureIgnoreCase) || letra.Equals("o",StringComparison.InvariantCultureIgnoreCase) || letra.Equals("a",StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine($"la letra {letra}, es una vocal");
            else
                Console.WriteLine($"La letra {letra}, es una consonante");
        }
        
    }
}
