// See https://aka.ms/new-console-template for more information
/*
2. Una tienda de ropa se encuentra en liquidación y está ofreciendo un descuento del 60%. Elaborar el algoritmo que permita ingresar el precio del producto y que nos muestre cuanto se debe de pagar
*/

double precioDelProducto, total, descuento = 0.60;

Console.Write("Ingresa el precio del producto: ");
precioDelProducto = Convert.ToDouble(Console.ReadLine());

total = precioDelProducto * descuento;

Console.WriteLine($"Tienes 60% en descuento que es: {total} dolares.");
Console.WriteLine($"Total a pagar es de: {precioDelProducto - total} dolares.");


