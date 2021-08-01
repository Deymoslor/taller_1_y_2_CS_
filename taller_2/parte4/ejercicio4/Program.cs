using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Porfavor digite la cantidad de letras que desea evaluar: ");
            int rep = int.Parse(Console.ReadLine());
            for (int i = 0; i < rep; i++){    
                Console.Write("Porfavor digite la letra del abecedario para saber si es vocal o consonante: ");
                String resp = Console.ReadLine();
                Letra(resp.ToLower());
            }
        
        }
        static private void Letra (String letra){
            switch (letra){
                case "a":
                    Console.WriteLine($"la letra {letra}, es una vocal");
                    break;
                case "e":
                    Console.WriteLine($"la letra {letra}, es una vocal");
                    break;
                case "i":
                    Console.WriteLine($"la letra {letra}, es una vocal");
                    break;
                case "o":
                    Console.WriteLine($"la letra {letra}, es una vocal");
                    break;
                case "u":
                    Console.WriteLine($"la letra {letra}, es una vocal");
                    break;
                default:
                Console.WriteLine($"La letra {letra}, es una consonante");
                break;
            }     
        }
    }
}
