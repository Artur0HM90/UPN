// See https://aka.ms/new-console-template for more information
/*
Utilizando C# y sentencias repetitivas
WHILE, desarrolle el siguiente enunciado.

Crear un programa, que permita calcular la suma de los primeros N números naturales positivos, el valor N será ingresado por teclado.
*/

int numero = 0, resultado = 0;

while (numero >= 0)
{
    Console.Write("Ingresa un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Debes ingresar números enteros.");
    }
    else
    {
        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine($"* {i}");
            resultado += i;
        }
        Console.WriteLine("==================");
        Console.WriteLine($"  La suma es: {i}");
        Console.WriteLine("==================");
        break;
    }
}
