int tamaño;
Console.Write("Ingrese el tamaño de la bandera (un número entero positivo): ");
tamaño = Convert.ToInt32(Console.ReadLine());

if (tamaño < 3)
{
    Console.WriteLine("El tamaño debe ser mayor o igual a 3 para formar una bandera válida.");
}
else
{
    for (int fila = 0; fila < tamaño; fila++)
    {
    
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("* ");

        for (int columna = 0; columna < tamaño * 3; columna++)
        {
            if (columna < tamaño || columna >= tamaño * 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("*");
        }
        Console.WriteLine();
    }

    for (int baseMastil = 0; baseMastil < 7; baseMastil++)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("*");
    }

    Console.ResetColor();
}