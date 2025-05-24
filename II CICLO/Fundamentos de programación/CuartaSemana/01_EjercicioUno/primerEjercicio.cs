// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo!");

//Caso:

//     Hombre  Mujer

//Obrero  10%    15%

//Empleado 15%    20%

//Gerencia 20%    30%

double sueldo, dscto = 0, sneto;

string? gen;

int cat;

do
{
    Console.Write("Ingresar el sueldo del trabajador: ");
    sueldo = Convert.ToDouble(Console.ReadLine());
} while (sueldo < 1025);


do
{
    Console.WriteLine("=====================");
    Console.WriteLine("Genero del trabajador");
    Console.WriteLine("=====================");
    Console.WriteLine("[H] Hombre");
    Console.WriteLine("[M] Mujer");
    Console.Write("Seleccione el genero del trabajador: ");
    gen = Console.ReadLine();
} while (gen != "H" && gen != "h");

do
{
    Console.WriteLine("========================");
    Console.WriteLine("Categoria del trabajador");
    Console.WriteLine("========================");
    Console.WriteLine("[1] Obrero");
    Console.WriteLine("[2] Empleado");
    Console.WriteLine("[3] Gerencia");

    Console.Write("Seleccione la categoria del trabajador: ");
    cat = Convert.ToInt32(Console.ReadLine());
} while (cat < 1 || cat > 3);


if (gen == "H" || gen == "h")

{
    switch (cat)
    {
        case 1: //Obrero
            dscto = sueldo * 0.1;
            break;

        case 2: //Empleado
            dscto = sueldo * 0.15;
            break;

        case 3://Gerencia
            dscto = sueldo * 0.2;
            break;

        default:
            Console.WriteLine("Ingrese una categoria valida");
            break;
    }
}

else
{
    switch (cat)

    {
        case 1: //Obrero
            dscto = sueldo * 0.15;
            break;

        case 2: //Empleado
            dscto = sueldo * 0.2;
            break;

        case 3://Gerencia
            dscto = sueldo * 0.3;
            break;

        default:
            Console.WriteLine("Ingrese una categoria valida");
            break;
    }
}

sneto = sueldo - dscto;

Console.WriteLine($"El descuento aplicado al trabajador es: S/{dscto} soles.");
Console.WriteLine($"El sueldo neto del trabajador es: S/{sneto} soles.");
Console.ReadKey();
