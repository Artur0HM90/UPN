using System;

class Program
{
    static void Main()
    {

        Console.Write("Introduce una frase: ");
        string frase = Console.ReadLine();


        while (true)
        {
            Console.Write("\nIntroduce una palabra (presiona ENTER para terminar): ");
            string palabra = Console.ReadLine();

            if (string.IsNullOrEmpty(palabra))
            {
                break;
            }


            if (frase.Contains(palabra))
            {
                Console.WriteLine($"La palabra '{palabra}' es parte de la frase.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' NO es parte de la frase.");
            }
        }

        Console.WriteLine("\nPrograma terminado.");
    }
}