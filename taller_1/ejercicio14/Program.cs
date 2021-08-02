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
            ArrayList valorSele = new ArrayList();
            int cant,selec;
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
                selec = int.Parse(Console.ReadLine())-1;
                selecionado.Add(articulos[selec]);
                valorSele.Add(valor[selec]);
            }

            Console.Write("Los productos que usted adquirio: \n");
            for (int i = 0; i < selecionado.Count; i++)
            {
                iva = (Convert.ToDecimal(valorSele[i])) * 0.19m;
                Console.Write($"\n El {i+1} articulo es {selecionado[i]} con un valor de ${((Convert.ToDecimal(valorSele[i])).ToString("N0"))} y con un iva de ${iva.ToString("N0")} para un total de ${((Convert.ToDecimal(valor[i]))+iva).ToString("N0")}.");
                total = total + ((Convert.ToDecimal(valorSele[i])) + iva);
            }
            Console.Write($"\nPara pagar un total de ${total.ToString("N0")}.\n");
        }
    }
}
