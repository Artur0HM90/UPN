int[] arreglo1 = new int[5];
int[] arreglo2 = new int[5];
int[] arreglo3 = new int[5];


void LlenarArreglo(int[] arreglo, string nombreArreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.Write($"Ingrese el valor para la posición {i} del {nombreArreglo}: ");
        arreglo[i] = int.Parse(Console.ReadLine());
    }
}


Console.Write("Llenando el Arreglo 1: ");
LlenarArreglo(arreglo1, "Arreglo 1");

Console.Write("Llenando el Arreglo 2: ");
LlenarArreglo(arreglo2, "Arreglo 2");


for (int i = 0; i < arreglo1.Length; i++)
{
    arreglo3[i] = arreglo1[i] + arreglo2[i];
}


Console.WriteLine("\nResultado de la suma de cada posición:");
for (int i = 0; i < arreglo1.Length; i++)
{
    Console.WriteLine($"Valor pos {i} arreglo 1 ({arreglo1[i]}) + valor pos {i} arreglo 2 ({arreglo2[i]}) = valor pos {i} arreglo 3 ({arreglo3[i]})");
}