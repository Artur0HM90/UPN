// See https://aka.ms/new-console-template for more information
/*
Utilizando C# y sentencias repetitivas
WHILE, desarrolle el siguiente enunciado.

Utilizando la sentencia WHILE se pide ingresar 6 números enteros positivos, luego, mostrar la cantidad de pares e impares ingresados.
*/

int ingresaNumero;
int contdor = 0;
while (ingresaNumero > 7)
{
    Console.Write("Ingresa un número: ");
    ingresaNumero = Convert.ToInt32(Console.ReadLine());
    if (ingresaNumero % 2 == 0)
    {
        Console.WriteLine($"Número es par: {ingresaNumero}");
    }
    else
    {
        Console.WriteLine($"Número es impar: {ingresaNumero}");
    }
}
*/