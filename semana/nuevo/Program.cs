Console.WriteLine("Arreglos Bidimensionales");



//Declaración de Matrices

int[,] arreglobi = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, } };



for (int i = 0; i < 3; i++)//Filas

{

    for (int j = 0; j < 3; j++)//Columnas

    {

        Console.Write(arreglobi[i, j] + " ");

    }

    Console.WriteLine();

}