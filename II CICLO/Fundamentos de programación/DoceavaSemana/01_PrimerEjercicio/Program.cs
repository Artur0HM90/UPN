// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo UPN - 2024\n");

//Declaración de arreglo

int[] array = new int[5];

int elemento;

//Insertando y recorriendo el arreglo

Console.WriteLine("Ingrese los elementos del array");

for (int i = 0; i < array.Length; i++)

{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Console.WriteLine("Los elementos del array son: ");

for (int i = 0; i < array.Length; i++)

{
    Console.WriteLine("Posición [" + i + "] = " + array[i]);
}

Console.Write("Ingrese el elemento que desea buscar: ");
elemento = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == elemento)
    {
        Console.WriteLine("Elemento encontrado en la posición " + (i + 1));
        break;
    }

    else
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine("No se encontro el elemento");
        }
    }
}



Console.ReadKey();