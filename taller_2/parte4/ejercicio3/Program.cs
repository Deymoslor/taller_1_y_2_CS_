using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dec, uni;
			String[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
			String[] decenas = { "diez" , "veinte" , "treinta" , "cuarenta" , "cincuenta" , "sesenta" , "setenta"
				, "ochenta" , "noventa" };
			Console.WriteLine("Ingresa un numero del 1 al 99");
			num = int.Parse(Console.ReadLine());
			dec = num / 10;
			uni = num % 10;
			if (num >= 1 && num <= 10)
			{
				switch (num)
				{
					case 1:
						Console.WriteLine("uno");
						break;
					case 2:
						Console.WriteLine("dos");
						break;
					case 3:
						Console.WriteLine("tres");
						break;
					case 4:
						Console.WriteLine("cuatro");
						break;
					case 5:
						Console.WriteLine("cinco");
						break;
					case 6:
						Console.WriteLine("seis");
						break;
					case 7:
						Console.WriteLine("siete");
						break;
					case 8:
						Console.WriteLine("oncho");
						break;
					case 9:
						Console.WriteLine("nueve");
						break;
					case 10:
						Console.WriteLine("diez");
						break;
				}
			}
			if (num >= 11 && num <= 15)
			{
				switch (num)
				{
					case 11:
						Console.WriteLine("once");
						break;
					case 12:
						Console.WriteLine("doce");
						break;
					case 13:
						Console.WriteLine("trece");
						break;
					case 14:
						Console.WriteLine("catorce");
						break;
				}
				if (uni == 0)
				{
					switch (num)
					{
						case 10:
							Console.WriteLine("diez");
							break;
						case 20:
							Console.WriteLine("veinte");
							break;
						case 30:
							Console.WriteLine("treinta");
							break;
						case 40:
							Console.WriteLine("cuarenta");
							break;
						case 50:
							Console.WriteLine("cincuenta");
							break;
						case 60:
							Console.WriteLine("sesenta");
							break;
						case 70:
							Console.WriteLine("setenta");
							break;
						case 80:
							Console.WriteLine("ochenta");
							break;
						case 90:
							Console.WriteLine("noventa");
							break;
					}
				}

			}
			if ((num / 10) <= 9 && (num / 10) >= 1)
			{
				Console.WriteLine((num / 10) + "and" + num % 10);
				Console.WriteLine("El numero " + num + " es " + decenas[dec - 1] + " y " + unidades[uni]);
			}
        }
    }
}
