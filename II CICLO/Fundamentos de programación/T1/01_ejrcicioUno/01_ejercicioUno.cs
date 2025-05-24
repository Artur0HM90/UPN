// See https://aka.ms/new-console-template for more information
/*
1.	Desarrolle un algoritmo que muestre la boleta de un cliente, sabiendo que compra en un minimarket como mínimo 3 articulos y el precio de cada articulo es ingresado por el vendedor. El pago se realiza con tarjeta de crédito y al contado, Considerar 18% de IGV.
Console.WriteLine("Hello, World!");
*/

int ingresaCantidadDeProductos;
double precioDelProducto, subtotal = 0, igv = 0.18, costoConIgv, total;

do
{
    Console.WriteLine("====================");
    Console.WriteLine("COMPRA DE ARTICULOS");
    Console.WriteLine("====================");
    Console.Write("cantos productos compraste - (mínimo 3): ");
    ingresaCantidadDeProductos = Convert.ToInt32(Console.ReadLine());
} while (ingresaCantidadDeProductos < 3);

for (int i = 1; i <= ingresaCantidadDeProductos; i++)
{
    Console.Write($"Costo del {i} articulo: ");
    precioDelProducto = Convert.ToDouble(Console.ReadLine());
    subtotal += precioDelProducto;
}

costoConIgv = subtotal * igv;
total = subtotal + costoConIgv;

Console.WriteLine("Subtotal: " + subtotal);
Console.WriteLine("IGV (18%): " + costoConIgv);
Console.WriteLine("=====================");
Console.WriteLine("Total a pagar: " + total);
Console.WriteLine("=====================");