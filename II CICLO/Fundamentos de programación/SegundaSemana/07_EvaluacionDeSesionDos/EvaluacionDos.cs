// See https://aka.ms/new-console-template for more information
/*
2. Realizar el algoritmo que me permite transformar horas a minutos
*/

double horas, total, horaMinitos = 60;


Console.Write("Ingrese una cifra en horas: ");
horas = Convert.ToDouble(Console.ReadLine());
total = horas * horaMinitos;
if (horas == 1)
{
    Console.Write($"{horas} hora a minutos es {total} minutos.");
}
else if (horas > 1)
{




    Console.Write($"{horas} horas a minutos es {total} minutos.");
}

