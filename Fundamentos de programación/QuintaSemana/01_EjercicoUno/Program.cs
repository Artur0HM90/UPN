// See https://aka.ms/new-console-template for more information

//Lanzamiento de 2 dados

int cant, d1, d2, suma;

//Console.Write("Ingrese la cantidad de veces que desea lanzar: ");
//cant = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

for (int i = 1; i <= 3; i++)
{
    do
    {
        d1 = r.Next(1, 7);
        d2 = r.Next(1, 7);
    } while (i == 3);


    suma = d1 + d2;
    Console.WriteLine("================");
    Console.WriteLine($" Lanzamiento {i}");
    Console.WriteLine("================");
    Console.WriteLine("El lado del dado 1 es: " + d1);
    Console.WriteLine("El lado del dado 2 es: " + d2);
    Console.WriteLine("La suma de los dados es: " + suma);
    Console.WriteLine("");
}

Console.ReadKey();