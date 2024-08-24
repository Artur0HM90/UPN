// See https://aka.ms/new-console-template for more information

/*
4. Realizar el algoritmo que permita realizar el tipo de cambio de soles a dólares (Sabiendo que 1 dolar
= 3.78 soles)
*/

double soles, cambio, valorDelDolar = 3.78;

Console.Write("Ingresa cuantos soles vas a cambiar: ");
soles = Convert.ToDouble(Console.ReadLine());

cambio = soles * valorDelDolar;

if (cambio == 1)
{
    Console.WriteLine($"El cambio de {soles} sole a doleres es {cambio}.");
}
else
{
    Console.WriteLine($"El cambio de {soles} soles a doleres es {cambio}.");
}