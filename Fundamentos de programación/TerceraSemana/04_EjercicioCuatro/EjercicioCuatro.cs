// See https://aka.ms/new-console-template for more information

/*
En una universidad, los alumnos están clasificados en cuatro categorías. A cada categoría le corresponde una pensión mensual distinta dada en la siguiente tabla.,

Categoria   Pension
    A       S/.550
    B       S/.500
    C       S/.460
    D       S/.400
Semestralmente, la universidad efectúa rebajas en las pensiones de sus estudiantes a partir del segundo ciclo basándose en el promedio ponderado del ciclo anterior en porcentajes dados en la tabla siguiente:

Promedio            Descuento
0 a 13.99         No hay descuento
14.00 a 15.99         10%
16.00 a 17.99         12%
18.00 a 20.00         15%

Dado el promedio ponderado y la categoría de un estudiante, diseñe un programa que determine cuánto de rebaja recibirá sobre su pensión actual y a cuánto asciende su nueva pensión.

*/

using System.Globalization;

int pensionCategoria_A = 550, pensionCategoria_B = 500, pensionCategoria_C = 460, pensionCategoria_D = 400;
double primerDescuento = 0.10, segundoDescuento = 0.12, tercerDescuento = 0.15;
int ingresaCiclo;
char ingresaCategoria;
double ingresaPromedioFinal;
char mayuscula;
//string primeraCategoria = "A", segundaCategoria = "B", terceraCategoria = "C", cuartaCategoria = "D";

do
{
    Console.Write("Ingrese en que ciclo esta el alumno: ");
    ingresaCiclo = Convert.ToInt32(Console.ReadLine());
} while (ingresaCiclo < 1 || ingresaCiclo > 10);

do
{
    Console.Write("Ingresa en que categoria estan el alumno: ");
    ingresaCategoria = Console.ReadKey().KeyChar;
    Console.WriteLine();
    mayuscula = char.ToUpper(ingresaCategoria);
} while (mayuscula != 'A' && mayuscula != 'B' && mayuscula != 'C' && mayuscula != 'D');

do
{
    Console.Write("Ingresa cuanto el promedio del alumno: ");
    ingresaPromedioFinal = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
} while (ingresaPromedioFinal < 0 || ingresaPromedioFinal > 20);




if (ingresaCiclo == 1)
{
    Console.WriteLine($"Estas en el {ingresaCiclo} Ciclo.");

    switch (mayuscula)
    {
        case 'A':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula} y tiene una pensión de S/{pensionCategoria_A} soles.");
            Console.WriteLine($"El promedio final es: {ingresaPromedioFinal}.");
            break;

        case 'B':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula} y tiene una pensión de S/{pensionCategoria_B} soles.");
            Console.WriteLine($"El promedio final es: {ingresaPromedioFinal}.");
            break;

        case 'C':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula} y tiene una pensión de S/{pensionCategoria_C} soles.");
            Console.WriteLine($"El promedio final es: {ingresaPromedioFinal}.");
            break;

        case 'D':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula} y tiene una pensión de S/{pensionCategoria_D} soles.");
            Console.WriteLine($"El promedio final es: {ingresaPromedioFinal}.");
            break;

        default:
            Console.WriteLine("ERROR - Debes ingresar A - B - C - D.");
            break;
    }
}
else
{
    Console.WriteLine($"Estas en el {ingresaCiclo} Ciclo.");

    switch (mayuscula)
    {
        case 'A':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula}.");
            if (ingresaPromedioFinal >= 0 && ingresaPromedioFinal <= 13.99)
            {
                Console.WriteLine("Hollla");
            }
            else if (ingresaPromedioFinal >= 14 && ingresaPromedioFinal <= 15.99)
            {
                Console.WriteLine("Hollxxxxla");
            }
            else if (ingresaPromedioFinal >= 16 && ingresaPromedioFinal <= 17.99)
            {
                Console.WriteLine("HollxxxClauxla");
            }
            else
            {
                Console.WriteLine("415646545646");
            }
            break;

        case 'B':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula}.");
            if (ingresaPromedioFinal >= 0 && ingresaPromedioFinal <= 13.99)
            {
                Console.WriteLine("Hollla");
            }
            else if (ingresaPromedioFinal >= 14 && ingresaPromedioFinal <= 15.99)
            {
                Console.WriteLine("Hollxxxxla");
            }
            else if (ingresaPromedioFinal >= 16 && ingresaPromedioFinal <= 17.99)
            {
                Console.WriteLine("HollxxxClauxla");
            }
            else
            {
                Console.WriteLine("415646545646");
            }
            break;

        case 'C':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula}.");
            if (ingresaPromedioFinal >= 0 && ingresaPromedioFinal <= 13.99)
            {
                Console.WriteLine("Hollla");
            }
            else if (ingresaPromedioFinal >= 14 && ingresaPromedioFinal <= 15.99)
            {
                Console.WriteLine("Hollxxxxla");
            }
            else if (ingresaPromedioFinal >= 16 && ingresaPromedioFinal <= 17.99)
            {
                Console.WriteLine("HollxxxClauxla");
            }
            else
            {
                Console.WriteLine("415646545646");
            }
            break;

        case 'D':
            Console.WriteLine($"El alumno esta en la categoria: {mayuscula}.");
            if (ingresaPromedioFinal >= 0 && ingresaPromedioFinal <= 13.99)
            {
                Console.WriteLine("Hollla");
            }
            else if (ingresaPromedioFinal >= 14 && ingresaPromedioFinal <= 15.99)
            {
                Console.WriteLine("Hollxxxxla");
            }
            else if (ingresaPromedioFinal >= 16 && ingresaPromedioFinal <= 17.99)
            {
                Console.WriteLine("HollxxxClauxla");
            }
            else
            {
                Console.WriteLine("415646545646");
            }
            break;

        default:
            Console.WriteLine("ERROR - Debes ingresar A - B - C - D.");
            break;
    }
}