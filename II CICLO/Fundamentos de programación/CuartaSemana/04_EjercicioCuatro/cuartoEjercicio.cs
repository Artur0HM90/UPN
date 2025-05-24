// See https://aka.ms/new-console-template for more information
/*
Se pide ingresar 2 números enteros positivos, luego ordenar los números de menor a mayor y mostrar todos los números que comprenden el rango, además la cantidad de números pares e impares que contiene el rango.,
*/

int ingresaPrimerNumero, ingresaSegundoNumero;

do
{
    Console.Write("Ingresa primer número: ");
    ingresaPrimerNumero = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa segundo número: ");
    ingresaSegundoNumero = Convert.ToInt32(Console.ReadLine());

    if (ingresaPrimerNumero >= ingresaSegundoNumero)
    {
        Console.ForegroundColor = ConsoleColor.Red;     // Para poner color rojo
        Console.Write("ERROR - El primer número debe ser menor.\n");
    }
    Console.ResetColor();   // Para cerrar el color rojo

} while (ingresaPrimerNumero >= ingresaSegundoNumero);

Console.WriteLine("\n====================");
Console.WriteLine("  LISTA DE NÚMEROS");
Console.WriteLine("====================");
for (int i = ingresaPrimerNumero; i <= ingresaSegundoNumero; i++)
{
    Console.Write($"{i},");
}
Console.ForegroundColor = ConsoleColor.Blue;    //Para poner color azul
Console.WriteLine("\n\n=================");
Console.WriteLine("  NÚMEROS PARES");
Console.WriteLine("=================");
for (int i = ingresaPrimerNumero; i <= ingresaSegundoNumero; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i},");
    }
}
Console.ResetColor();  // Para cerrar el color azul

Console.ForegroundColor = ConsoleColor.Yellow;      // Para poner color amarillo
Console.WriteLine("\n\n===================");
Console.WriteLine("  NÚMEROS IMPARES");
Console.WriteLine("===================");
for (int i = ingresaPrimerNumero; i <= ingresaSegundoNumero; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i},");
    }
}
Console.ResetColor();       // Para cerrar el color azul