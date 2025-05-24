// See https://aka.ms/new-console-template for more information
/*
Utilizando C# y sentencias repetitivas
WHILE, desarrolle el siguiente enunciado.
Se solicita ingresar por teclado un número y mostrar la tabla de multiplicar del 0 al 12 del número ingresado, el resultado debe ser de la siguiente forma si se ingresa el número 2:
*/

int numero = 1, ingresaNumero;

Console.Write("Que tabla de multiplicar vas ejecutar: ");
ingresaNumero = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=================");
Console.WriteLine($"LA TABLA DE {ingresaNumero}");
Console.WriteLine("=================");
Console.ResetColor();

while (numero <= 12)
{
    Console.WriteLine($"{ingresaNumero} x {numero} = {ingresaNumero * numero}");
    numero++;
}