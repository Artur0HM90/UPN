// See https://aka.ms/new-console-template for more information

int partidosGanados, partidosEmpatados, partidosPerdidos, puntajeFinalDelEquipo;
int puntosPorPartidosGanados = 3;
Console.WriteLine("========================");
Console.WriteLine("PARTIDO DE FUTBOL PERUANO");
Console.WriteLine("========================");
Console.WriteLine("Puntos Ganados   [3]");
Console.WriteLine("Puntos Empatados [2]");
Console.WriteLine("Puntos Ganados   [0]");

do
{
    Console.Write("Ingresa cauntos partidos ganastes: ");
    partidosGanados = Convert.ToInt32(Console.ReadLine());
} while (partidosGanados <= 0);

Console.Write("Ingrese el número de partidos empatados: ");
partidosEmpatados = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el número de partidos perdidos: ");
partidosPerdidos = Convert.ToInt32(Console.ReadLine());

puntajeFinalDelEquipo = (partidosGanados * puntosPorPartidosGanados) + partidosEmpatados;

Console.WriteLine("===============================");
Console.WriteLine($"El puntaje  del equipo es: {puntajeFinalDelEquipo}");
Console.WriteLine("===============================");


if (puntajeFinalDelEquipo < 10)
{
    Console.WriteLine("El equipo ha descendido.");
}