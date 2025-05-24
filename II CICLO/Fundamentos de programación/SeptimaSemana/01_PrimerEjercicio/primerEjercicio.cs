// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Algoritmo que imprima la serie 0, 1, 1, 2, 3, 5, 8, 13, ...



int cant, a = 0, b = 1, vtem;

Console.Write("Ingrese la cantidad de terminos de la serie: ");

cant = int.Parse(Console.ReadLine());



for (int i = 1; i <= cant; i++)

{

    Console.WriteLine(a);

    vtem = a + b;

    a = b;

    b = vtem;

}
int[] numeros = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };



foreach (int elemento in numeros)

{

    if (elemento == 5)

    {

        break;

    }

    Console.Write(elemento + " ");

}

Console.WriteLine("Fin, elemento encontrado");


Console.ReadKey();