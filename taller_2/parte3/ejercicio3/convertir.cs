using System;
namespace ejercicio3
{
    class convertir
        {
            private String[] UNIDADES = {"cero ","uno ","dos ","tres ","cuatro ","cinco ","seis ","siete ","ocho ","nueve "};
            private String[] DECENAS = {"diez ","once ","doce ","trece ","catorce ","quince ","dieciseis ","diecisiete ","dieciocho ","diecinueve ","veinte ","treinta ","cuarenta ","cincuenta ","sesenta ","setenta ","ochenta ","noventa "};
            private String[] CENTENAS = {"cien "};

            public String Convertir(String numero, bool mayusculas)
                {
                    String literal = "";
                    char delimitador = ';';
                    String parte_decimal;
                    numero = numero.Replace(".", ",");
                    if (numero.IndexOf(",") == -1)
                    {
                        numero = numero + ",00";
                    }
                    if (matches("\\d{1,9},\\d{1,2}", numero))
                    {
                        String [] Num = numero.Split(delimitador);
                        parte_decimal = Num[1] + "/100 soles.";
                        if (Int32.Parse(Num[0]) == 0)
                        {
                            literal = "cero ";
                        }
                        if (Int32.Parse(Num[0]) > 99)
                        {
                            literal = getCentenas(Num[0]);
                        }
                        else if (Int32.Parse(Num[0]) > 9)
                        {
                            literal = getDecenas(Num[0]);
                        }
                        else
                        {
                            literal = getUnidades(Num[0]);
                        }
                    }
                    if (Pattern.matches("\\d{1,9},\\d{1,2}", numero))
                    {
                        String [] Num = numero.Split(",");
                        parte_decimal = Num[1] + "/100 soles.";
                        if (mayusculas)
                        {
                            return (literal + parte_decimal).ToUpper();
                        }
                        else
                        {
                            return (literal + parte_decimal);
                        }
                    }
                    else
                    {
                        return literal = null;
                    }
                }

                private String getUnidades(String numero)
                {
                    String num = numero.Substring(numero.Length - 1);
                    return UNIDADES[Int32.Parse(num)];
                }

                private String getDecenas(String num)
                {
                    int n = Int32.Parse(num);
                    if (n < 10)
                    {
                        return getUnidades(num);
                    }
                    else if (n > 19)
                    {
                        String u = getUnidades(num);
                        if (u == (""))
                        {
                            return DECENAS[Int32.Parse(num.Substring(0, 1)) + 8];
                        }
                        else
                        {
                            return DECENAS[Int32.Parse(num.Substring(0, 1)) + 8] + "y " + u;
                        }
                    }
                    else
                    {
                        return DECENAS[n - 10];
                    }
                }

                private String getCentenas(String num)
                {
                    if (Int32.Parse(num) > 99)
                    {
                        if (Int32.Parse(num) == 100)
                        {
                            return " cien";
                        }
                        else
                        {
                            return CENTENAS[Int32.Parse(num.Substring(0, 1))] + getDecenas(num.Substring(1));
                        }
                    }
                    else
                    {
                        return getDecenas(Int32.Parse(num) + "");
                    }
                }
            }
}