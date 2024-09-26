// See https://aka.ms/new-console-template for more information
/*

Utilizando C# y sentencias repetitivas DO WHILE, desarrolle el siguiente enunciado.
Diseñe un programa que genere númerc aleatorios enteros del intervalo 100 a 999 hastu obtener un número par mayor o igual a 500.
Imprima lo números generados y determine:
• La suma de los números generados
• La cantidad de números pares generados
• La cantidad de números impares generados
• La suma de los números pares generados
• La suma de los números impares generados
*/

int ingresaNumero = 0, solucion = 0;

do
{
    Console.Write("Ingrese un número entre 100 a 999: ");
    ingresaNumero = int.Parse(Console.ReadLine());
    if (ingresaNumero % 2 == 0 || ingresaNumero >= 500)
    {
        Console.WriteLine($"La suma es: {solucion}");
        solucion += ingresaNumero;
    }
    else
    {

    }
} while (ingresaNumero >= 100 || ingresaNumero <= 999);