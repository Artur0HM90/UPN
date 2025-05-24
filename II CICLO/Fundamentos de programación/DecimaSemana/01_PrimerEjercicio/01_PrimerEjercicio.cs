// See https://aka.ms/new-console-template for more information


int ingreseNumero;
do
{
    Console.Write("Ingrese un número: ");
    ingreseNumero = Convert.ToInt32(Console.ReadLine());
    if (ingreseNumero <= 0 || ingreseNumero >= 16)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Debes ingresar un número del 1 al 15.");
        Console.ResetColor();
    }

} while (ingreseNumero <= 0 || ingreseNumero >= 16);

for (int i = 1; i < ingreseNumero; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.ForegroundColor = ConsoleColor.Green; // esta linea es para poner el color
        Console.Write("*");
        Console.ResetColor(); // esta linea es para que el color se corte ahi
    }
    Console.WriteLine();
}

Console.ReadKey();

