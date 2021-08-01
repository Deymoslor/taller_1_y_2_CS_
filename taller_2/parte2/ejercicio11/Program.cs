using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor, propio, prestamo, credito;
            Console.Write("Ingrese el valor de la compra de las piezas: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor >= 5000000){
                propio = valor * 0.55m;
                prestamo = valor * 0.3m;
                credito = valor * 0.15m;
                /*fabricante = valor - (propio + banco);*/

                Console.WriteLine($"\nLa empresa pagará de la siguiente manera:\n    - Con recursos propios: ${propio.ToString("N0")}.\n    - Pedirá prestado {prestamo.ToString("N0")} al banco.\n    - Solicitará un crédito de {credito.ToString("N0")} al fabricante, al cual se le pagará {(credito*0.15m).ToString("N0")} de intereses.");
                Console.Write($"\nLo cual da un total de: {(propio+prestamo+credito+(credito * 0.15m)).ToString("N0")}.\n");
            }
            else
            {
                propio = valor * 0.7m;
                credito = valor * 0.3m;
                Console.WriteLine($"\nLa empresa pagará de la siguiente manera:\n    - Con recursos propios: ${propio.ToString("N0")}.\n    - Solicitará un crédito de {credito.ToString("N0")} al fabricante, al cual se le pagará {(credito * 0.15m).ToString("N0")} de intereses.");
                Console.Write($"\nLo cual da un total de: {(propio + credito + (credito * 0.15m)).ToString("N0")}.\n");
            }
        }
    }
}
