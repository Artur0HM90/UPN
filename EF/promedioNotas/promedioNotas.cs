static double primeraNota(double notaUno)
{
    return notaUno * 0.10;
}
static double segundaNota(double notaDos)
{
    return notaDos * 0.10;
}
static double terceraNota(double notaTres)
{
    return notaTres * 0.10;
}
static double cuartaNota(double notaCuarta)
{
    return notaCuarta * 0.30;
}
static double quintaNota(double notaQuinta)
{
    return notaQuinta * 0.40;
}



int cantidadDeEstudiantes;
double promedioFinal = 0;
List<string> nombres = new List<string>();
double ingresaNotaT1 = 0, ingresaNotaT2 = 0, ingresaNotaT3 = 0, ingresaNotaEP = 0, ingresaNotaEF = 0;

Console.Write("Ingresa cuántos estudiantes son: ");
cantidadDeEstudiantes = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (cantidadDeEstudiantes == 1)
{
    Console.WriteLine("=============================");
    Console.WriteLine("INGRESA NOMBRE DEL ESTUDIANTE");
    Console.WriteLine("=============================");
    Console.Write("Ingresa nombre del estudiante: ");
    string nombre = Console.ReadLine().ToUpper();
    nombres.Add(nombre);

    Console.Write("Ingresa la nota del T1: ");
    ingresaNotaT1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingresa la nota del T2: ");
    ingresaNotaT2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingresa la nota del T3: ");
    ingresaNotaT3 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingresa la nota del EP: ");
    ingresaNotaEP = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingresa la nota del EF: ");
    ingresaNotaEF = Convert.ToDouble(Console.ReadLine());

    Console.Clear();
}

else
{
    for (int i = 1; i <= cantidadDeEstudiantes; i++)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("INGRESA NOMBRE DE LOS ESTUDIANTES");
        Console.WriteLine("==================================");
        Console.Write($"Ingresa el {i} nombre: ");
        string nombre = Console.ReadLine().ToUpper();
        nombres.Add(nombre);

        Console.Write("Ingresa la nota del T1: ");
        ingresaNotaT1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la nota del T2: ");
        ingresaNotaT2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la nota del T3: ");
        ingresaNotaT3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la nota del EP: ");
        ingresaNotaEP = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la nota del EF: ");
        ingresaNotaEF = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
    }
}

double calificacionUno = primeraNota(ingresaNotaT1);
double calificacionDos = segundaNota(ingresaNotaT2);
double calificacionTres = terceraNota(ingresaNotaT3);
double calificacionCuatro = cuartaNota(ingresaNotaEP);
double calificacionCinco = quintaNota(ingresaNotaEF);

promedioFinal = calificacionUno + calificacionDos + calificacionTres + calificacionCuatro + calificacionCinco;

Console.WriteLine("Nombres ingresados:");
//Console.WriteLine("Nombres".PadRight(15) + "T1(10 %)".PadRight(10) + "T2(10 %)".PadRight(10) + "T3(10 %)".PadRight(15) + "EP(30 %)".PadRight(10) + "EF(40 %)".PadRight(10) + "Promedio".PadRight(10));
Console.WriteLine("Nombres".PadRight(15) + "T1(10 %)".PadRight(10) + "T2(10 %)".PadRight(10) + "T3(10 %)".PadRight(10) + "EP(30 %)".PadRight(10) + "EF(40 %)".PadRight(10) + "Promedio".PadRight(10));

foreach (string nombre in nombres)
{
    //Console.WriteLine($"{nombre,-15}{calificacionUno:F0,-10}{calificacionDos:F0,-10}{calificacionTres:F0,-10} {calificacionCuatro:F0,-10}{calificacionCinco:F0,-10}{promedioFinal}");
    //Console.WriteLine($"{nombre,-15} {calificacionUno:F0,-10} {calificacionDos:F0,-10} {calificacionTres:F0,-10} {calificacionCuatro:F0,-10} {calificacionCinco:F0,-10} {promedioFinal:F2}");
    Console.WriteLine($"{nombre,-5} {calificacionUno,10:F0} {calificacionDos,10:F0} {calificacionTres,10:F0} {calificacionCuatro,10:F0} {calificacionCinco,10:F0} {promedioFinal,10}");
}

