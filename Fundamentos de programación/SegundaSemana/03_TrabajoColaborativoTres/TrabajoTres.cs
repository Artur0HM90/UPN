// See https://aka.ms/new-console-template for more information

/*
3. Desarrollar el algoritmo que permita ingresar 2 números y el programa mostrara el resultado de la
siguiente operación: (x+y)*(x-y)
*/
double primerNumero, segundoNumero, resultado;

Console.Write("Ingresa el primer número: ");
primerNumero = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
segundoNumero = Convert.ToDouble(Console.ReadLine());

resultado = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);

Console.WriteLine($"El resultado es: {resultado}.");
