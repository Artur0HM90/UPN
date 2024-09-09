// See https://aka.ms/new-console-template for more information
/*
Crear un programa que solicite por teclado la cantidad de números a ingresar, luego se ingresará la cantidad de números indicada por teclado y como resultado se mostrarám el promedio de todos los números ingresados, el número mayor y el número menor de todos los números ingresados.
*/

int ingresaNumeros;
double ingresaNumerosLista, suma = 0, promedio = 0;

Console.Write("Ingrese cuantos números vas ingresar: ");
ingresaNumeros = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= ingresaNumeros; i++)
{
    Console.Write($"Ingresa {i} número: ");
    ingresaNumerosLista = Convert.ToDouble(Console.ReadLine());
    suma += ingresaNumerosLista;
}
promedio = suma / ingresaNumeros;
Console.WriteLine($"La suma es: {suma}.");
Console.WriteLine($"El promedio es: {promedio}.");

/*
Console.WriteLine($"Número mayor es : {ingresaNumerosLista.Max()}");
Console.WriteLine($"Número menor es : {ingresaNumerosLista.Min()}");
*/