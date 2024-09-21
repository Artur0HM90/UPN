// See https://aka.ms/new-console-template for more information
/*
Utilizando C# y sentencias repetitivas
WHILE, desarrolle el siguiente enunciado.

Utilizando la sentencia WHILE se pide ingresar 6 números enteros positivos, luego, mostrar la cantidad de pares e impares ingresados.
*/

int contador = 0, Numero = 0;

Console.Write("Ingresa cuantos números vas inghresar: ");
Numero = int.Parse(Console.ReadLine());

int[] Numeros = new int[Numero];

while (contador < Numero)
{
    Console.Write($"Ingresa {contador + 1} número: ");
    Numeros[contador] = int.Parse(Console.ReadLine());
    contador++;
}

Console.WriteLine("Resultados");
contador = 0;
while (contador < Numero)
{
    if (Numeros[contador] % 2 == 0)
    {
        Console.WriteLine($"El número {Numeros[contador]} es par.");
    }
    else
    {
        Console.WriteLine($"El número {Numeros[contador]} es impar.");
    }
    contador++;
}

