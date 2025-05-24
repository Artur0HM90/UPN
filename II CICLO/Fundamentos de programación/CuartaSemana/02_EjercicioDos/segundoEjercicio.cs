// See https://aka.ms/new-console-template for more information


/*
int lado;
Random r = new Random();
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine("Interación" + i);
    lado = r.Next(1, 6);
    //Console.WriteLine("interacion " + i);
    //suma += 3;
    Console.WriteLine("El lado de dado es: " + lado);
}

// Console.WriteLine($"La suma es: {suma}");
*/

//int nro;

Random r = new Random();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Interación " + i);
    Console.WriteLine(Math.Round(r.NextDouble() * (10 - 100) + 100, 2));
}

Console.ReadKey();
