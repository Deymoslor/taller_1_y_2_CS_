using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
            decimal valor,iva,total,descuento,val;
            String respuesta;

            Console.Write("Ingrese el valor de la compra: ");
            valor = decimal.Parse(Console.ReadLine());

            Console.Write("Autoriza el descuento: ");
            respuesta = Console.ReadLine();

            if ((respuesta == "SI")||(respuesta == "Si")|| (respuesta == "si"))
            {
                descuento = valor*0.10m;
                val = valor - descuento;
                iva = val * 0.19m;
                total = val + iva;

                Console.Write($"\nEl valor de la compra es de: ${valor.ToString("N0")}, al cual se le autorizó un descuento de ${descuento.ToString("N0")}, el Iva de este producto es de: {iva.ToString("N0")}, lo cual da para un valor a pagar de ${total.ToString("N0")}.");
            }
            else
            {
                iva = valor * 0.19m;
                total = valor + iva;

                Console.Write($"\nEl valor de la compra es de: ${valor.ToString("N0")}, el cual tiene un iva de ${iva.ToString("N0")}; para un total a pagar de  ${total.ToString("N0")}");
            }
        }
    }
}
