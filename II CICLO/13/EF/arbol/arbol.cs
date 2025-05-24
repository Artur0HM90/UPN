int tamaño;

do
{
    Console.Write("Ingrese el tamaño del árbol (un número entero positivo mayor o igual a 3): ");
    tamaño = Convert.ToInt32(Console.ReadLine());

    if (tamaño < 3)
    {
        Console.WriteLine("El tamaño debe ser mayor o igual a 3 para formar un árbol válido.");
    }
} while (tamaño < 3);



    Random random = new Random();


    for (int fila = 0; fila < tamaño; fila++)
    {
        
        for (int espacio = 0; espacio < tamaño - fila - 1; espacio++)
        {
            Console.Write(" ");
        }

        
        for (int asterisco = 0; asterisco < (2 * fila + 1); asterisco++)
        {
            int luz = random.Next(0, 5);
            if (luz == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.Write(".");
            }
            else if (luz == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(".");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }

    
    int anchoMacetero = tamaño / 2 + 1; 
    int altoMacetero = tamaño / 3; 

    for (int filaMacetero = 0; filaMacetero < altoMacetero; filaMacetero++)
    {
        
        for (int espacio = 0; espacio < tamaño - anchoMacetero; espacio++)
        {
            Console.Write(" ");
        }

        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        for (int columna = 0; columna < anchoMacetero * 2 - 1; columna++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }

    Console.ResetColor();
