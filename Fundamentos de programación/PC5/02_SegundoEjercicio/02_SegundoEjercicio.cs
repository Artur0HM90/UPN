// See https://aka.ms/new-console-template for more information
/*

Construya el siguiente programa. Debido a la pandemia la universidad ha decidido que se les debe calcular a todos los trabajadores y alumnos el Índice de Masa Corporal. Para ello les piden crear seudocódigo para dicho calculo, sabiendo que, la fórmula es la siguiente:

IMC=(Peso(Kg))/〖(Altura (m))〗^2 

*/

double peso, talla, IMC;

do
{
    Console.Write("Ingresa tu peso: ");
    peso = Convert.ToDouble(Console.ReadLine());
    if (peso <= 0)
    {
        Console.WriteLine("El peso debe ser mayor a cero");
    }
} while (peso <= 0);

do
{
    Console.Write("Ingresa tu talla en metros: ");
    talla = Convert.ToDouble(Console.ReadLine());
    if (talla <= 0)
    {
        Console.WriteLine("La talla debe ser mayor a cero");
    }
} while (talla <= 0);

//  FORMULA 
IMC = (peso) / Math.Pow(talla, 2);

Console.WriteLine("==========");
Console.WriteLine("RESULTADO");
Console.WriteLine("==========");
Console.WriteLine($"Tu IMC es: {IMC:F2}");