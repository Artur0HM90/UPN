// See https://aka.ms/new-console-template for more information

int ingreseNumero = 0;
Console.Write("Ingrese un número: ");
ingreseNumero = int.Parse(Console.ReadLine());
for (int i = 0; i <= ingreseNumero; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{j} ");
    }
    Console.WriteLine();
}