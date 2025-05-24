// See https://aka.ms/new-console-template for more information

/*
Utilizando For se solicita ingresar 5 números enteros por teclado entre positivos, negativos y ceros. Como resultado se mostrará la cantidad de positivos, negativos y ceros, además la suma de positivos y negativos.
*/

int numero = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingresa {i}: ");
    numero = Convert.ToInt32(Console.ReadLine());
}
if (numero == 0)
{
    Console.WriteLine($"Números negativos son: {numero}.");
}
else if (numero >= 1)
{
    Console.WriteLine($"Números positivos son: {numero}.");
}

else if (numero < 0)
{
    Console.WriteLine($"Números negativos son: {numero}.");
}