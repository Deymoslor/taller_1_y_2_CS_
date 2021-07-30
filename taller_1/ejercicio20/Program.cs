using System;

namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el precio de compra unitario: ");
            Double precioUnitario = Double.Parse(Console.ReadLine());
            Console.Write("Digite la cantidad de productos que va a llevar: ");
            Double cantidad = Double.Parse(Console.ReadLine());
            Console.Write("Digite el descuento del producto en porcentaje por favor: ");
            Double descuentoPorcentaje = Double.Parse(Console.ReadLine());
            
            Double subTotal = precioUnitario*cantidad;
            Double iva = subTotal*0.19;
            Double precioParcial = subTotal+iva;
            Double descuentoDecimal = descuentoPorcentaje / 100;
            Double precioNeto = precioParcial-(precioParcial*descuentoDecimal);
            
            Console.Write($"El subtotal de su compra es, {subTotal}, que con un iba del 19% equivalente a, {iva} y un descuento del {descuentoPorcentaje}%, dejaría un precio neto de, {precioNeto}");
        }
    }
}
