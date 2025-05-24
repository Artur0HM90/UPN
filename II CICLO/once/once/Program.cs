using System;
using Movilidades;

class ProgramaPrincipal
{
    static void Main()
    {
        int opcion;
        Console.WriteLine("Seleccione el tipo de vehículo:");
        Console.WriteLine("[1]. Auto");
        Console.WriteLine("[2]. Station Wagon");
        Console.WriteLine("[3]. Camioneta");
        Console.WriteLine("[4]. Camión");
        Console.Write("Elige 1 - 4: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la marca del vehículo (TOYOTA, NISSAN, HYUNDAI):");
        string marca = Console.ReadLine().ToUpper();

        Console.WriteLine("Ingrese el año del vehículo (2020, 2021, 2022):");
        int año = int.Parse(Console.ReadLine());

        double precioFinal = 0;

        switch (opcion)
        {
            case 1:
                precioFinal = Concesionaria.MetodoAuto(marca, año);
                break;
            case 2:
                precioFinal = Concesionaria.MetodoStation(marca, año);
                break;
            case 3:
                precioFinal = Concesionaria.MetodoCamioneta(marca, año);
                break;
            case 4:
                precioFinal = Concesionaria.MetodoCamion(marca, año);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        Console.WriteLine($"El precio final del vehículo es: ${precioFinal:F2}");
    }
}