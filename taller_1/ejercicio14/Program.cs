using System;
using System.Collections;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList articulos = new ArrayList();
            ArrayList valor = new ArrayList();
            ArrayList selecionado = new ArrayList();
            int cant;
            decimal iva, total = 0;

            Console.Write("Ingrese cuantos articulos desea agregar: ");
            cant = int.Parse(Console.ReadLine());

            articulos.Add("Sepillo de dientes");
            articulos.Add("Colino");
            articulos.Add("Jabón");
            articulos.Add("Desodrante");
            articulos.Add("Crema para afeitar");
            articulos.Add("Cuchilla de afeitar");

            valor.Add(1000);
            valor.Add(2000);
            valor.Add(3000);
            valor.Add(10000);
            valor.Add(12000);
            valor.Add(5000);


            Console.Write("          Articulos          ");
            for ( int i = 0; i < articulos.Count; i++)
            {
                Console.Write($"\n{i+1}. {articulos[i]}      ${((Convert.ToDecimal(valor[i])).ToString("N0"))}");
            }

            for (int i = 0; i < cant; i++)
            {
                Console.Write($"\nIngrese el número del {i + 1} articulo a agregar: ");
                selecionado.Add((int.Parse(Console.ReadLine()))-1);
            }

            Console.Write("Los productos que usted adquirio: \n");
            for (int i = 0; i < cant; i++)
            {
                iva = (Convert.ToDecimal(valor[i])) * 0.19m;
                Console.Write($"\n El {i+1} articulo es {articulos[i]} con un valor de ${((Convert.ToDecimal(valor[i])).ToString("N0"))} y con un iva de ${iva.ToString("N0")} para un total de ${((Convert.ToDecimal(valor[i]))+iva).ToString("N0")}.");
                total = total + ((Convert.ToDecimal(valor[i])) + iva);
            }
            Console.Write($"\nPara pagar un total de ${total.ToString("N0")}.\n");
        }
    }
}
