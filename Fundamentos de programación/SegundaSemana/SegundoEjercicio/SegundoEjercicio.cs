// See https://aka.ms/new-console-template for more information

// Desarrollar un algoritmo que sume los 'n' primeros números naturales


// Primera forma de resolver.

int ingreNumero, resultado;

Console.Write("Ingrese un número: ");
ingreNumero = Convert.ToInt32(Console.ReadLine());

resultado = (ingreNumero * (ingreNumero + 1)) / 2;

Console.Write($"El resultado es: {resultado}");


