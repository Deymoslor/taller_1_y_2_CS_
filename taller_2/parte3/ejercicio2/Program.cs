using System;

namespace ejercicio_02
{
    class ejercicio_02
    {

        private int n;
        private int cont;
        private decimal salario;

        private void num()
        {
            Console.WriteLine("Ingrese número de sueldos a ingresar: ");
            n = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            ejercicio_02 n = new ejercicio_02();
            n.condicional();


            Console.ReadKey();
        }



        private void condicional()
        {
            decimal mayor = 0;
            ejercicio_02 n = new ejercicio_02();
            n.num();
            if (n.n <= 0){
                Console.WriteLine("El número debe ser mayor a cero");
                n.num();
            }else{
                while ((n.n) != cont)
                {
                    Console.WriteLine("Inserte sueldo: ");
                    salario = decimal.Parse(Console.ReadLine());
                    
                    cont = cont+1;
                    if (salario > mayor)
                        mayor = salario;

                }
                Console.WriteLine($"Mayor: ${mayor.ToString("N0")}");
            }
        }

        
    }
}
