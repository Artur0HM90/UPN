// See https://aka.ms/new-console-template for more information

/*
1. Desarrollar el algoritmo que permita ingresar su nombre e imprimir en pantalla (Consola) con un mensaje de bienvenida
*/

string? ingreseNombre;

Console.Write("Ingrese sus nombres: ");
ingreseNombre = Console.ReadLine();

Console.Write("-------------------------------------------------\n");
Console.WriteLine($"Bienvenido {ingreseNombre} a la UPN");
Console.Write("-------------------------------------------------\n");
