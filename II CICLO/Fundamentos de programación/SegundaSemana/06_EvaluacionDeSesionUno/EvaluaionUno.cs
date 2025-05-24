// See https://aka.ms/new-console-template for more information
/*
1. A un empleado le incrementaron el sueldo a un 25%. Realizar el algoritmo que permite ingresar el sueldo y
calcular el incremento de su sueldo.
*/

double sueldo, resultado, porentaje = 0.25;

Console.Write("Ingresa el sueldo del trabajado: ");
sueldo = Convert.ToDouble(Console.ReadLine());

resultado = sueldo * porentaje;

Console.WriteLine($"Tu sueldo es: {sueldo} dolares.");
Console.WriteLine($"Ganaste 25% mas que es: {resultado} dolares.");
Console.WriteLine($"Tu ganancia es de: {sueldo + resultado} dolares.");

