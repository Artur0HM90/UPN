// See https://aka.ms/new-console-template for more information

/*
1.	En una universidad, los alumnos están clasificados en cuatro categorías. A cada categoría le corresponde una pensión mensual distinta dada en la siguiente tabla:
Categoría	Pensión
    A	    S/. 550
    B	    S/. 500
    C	    S/. 460
    D	    S/. 400
Semestralmente, la universidad efectúa rebajas en las pensiones de sus estudiantes a partir del segundo ciclo basándose en el promedio ponderado del ciclo anterior en porcentajes dados en la tabla siguiente:
    Promedio	          Descuento
0 a 13.99	          No hay descuento
14.00 a 15.99	            10 %
16.00 a 17.99           	12 %
18.00 a 20.00	            15 %
Dado el promedio ponderado y la categoría de un estudiante, diseñe un programa que determine cuánto de rebaja recibirá sobre su pensión actual y a cuánto asciende su nueva pensión.
*/

int eleigeCategoria, ingresaCiclo;

// Categorias
int categoria_A = 550, categoria_B = 500, categoria_C = 460, categoria_D = 400;

// Descuentos
double primerDescuento = 0.10, segundoDescuento = 0.12, tercerDescuento = 0.15;

//notas - Vamos ingresar 4 notas de las cuales y se dividira y saldra el promedio final del alumno.
double ingreseNotas, nota = 0, mensualidad = 0, descuento = 0;

string primerCategoria = "A";
string segundaCategoria = "B";
string terceraCategoria = "C";
string cuartaCategoria = "D";

do
{
    Console.Write("=========================\n");
    Console.Write("Elige en que ciclo estas:\n");
    Console.Write("=========================\n");

    Console.Write("[1] I cilco:\n");
    Console.Write("[2] II cilco:\n");
    Console.Write("[3] III cilco:\n");
    Console.Write("[4] IV cilco:\n");
    Console.Write("[5] V cilco:\n");
    Console.Write("[6] VI cilco:\n");
    Console.Write("[7] VII cilco:\n");
    Console.Write("[8] VIII cilco:\n");
    Console.Write("[9] IX cilco:\n");
    Console.Write("[10] X cilco:\n");
    Console.Write("Elige entre 1 - 10: ");
    ingresaCiclo = Convert.ToInt32(Console.ReadLine());
    if (ingresaCiclo <= 0 || ingresaCiclo >= 11)
    {
        Console.WriteLine("\nERROR - Debes ingresar un número entre 1 - 10.\n");
    }
} while (ingresaCiclo <= 0 || ingresaCiclo >= 11);

do
{
    Console.Write("\n=====================\n");
    Console.Write("Elige tu categoria:\n");
    Console.Write("=====================\n");
    Console.Write("[1] Categoría A.\n");
    Console.Write("[2] Categoría B.\n");
    Console.Write("[3] Categoría C.\n");
    Console.Write("[4] Categoría D.\n");
    Console.Write("Elige entre 1 - 4: ");
    eleigeCategoria = Convert.ToInt32(Console.ReadLine());
    if (eleigeCategoria <= 0 || eleigeCategoria >= 5)
    {
        Console.WriteLine("\nERROR - Debes ingresar un número entre 1 - 4.");
    }
} while (eleigeCategoria <= 0 || eleigeCategoria >= 5);

Console.Write("Ingrese la nota del alumno: ");
ingreseNotas = Convert.ToDouble(Console.ReadLine());


switch (ingresaCiclo)
{
    case 1:
        Console.WriteLine("=======");
        Console.WriteLine("I CICLO");
        Console.WriteLine("=======");
        if (eleigeCategoria == 1)
        {
            nota = ingreseNotas;
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
            mensualidad = categoria_A;
        }
        else if (eleigeCategoria == 2)
        {
            nota = ingreseNotas;
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
            mensualidad = categoria_B;
        }
        else if (eleigeCategoria == 3)
        {
            nota = ingreseNotas;
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
            mensualidad = categoria_C;
        }
        else
        {
            nota = ingreseNotas;
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
            mensualidad = categoria_D;

        }
        break;

    case 2:
        Console.WriteLine("========");
        Console.WriteLine("II CICLO");
        Console.WriteLine("========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 3:
        Console.WriteLine("=========");
        Console.WriteLine("III CICLO");
        Console.WriteLine("=========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 4:
        Console.WriteLine("========");
        Console.WriteLine("IV CICLO");
        Console.WriteLine("========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 5:
        Console.WriteLine("=======");
        Console.WriteLine("V CICLO");
        Console.WriteLine("=======");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 6:
        Console.WriteLine("========");
        Console.WriteLine("VI CICLO");
        Console.WriteLine("========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 7:
        Console.WriteLine("=========");
        Console.WriteLine("VII CICLO");
        Console.WriteLine("=========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 8:
        Console.WriteLine("==========");
        Console.WriteLine("VIII CICLO");
        Console.WriteLine("==========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 9:
        Console.WriteLine("========");
        Console.WriteLine("IX CICLO");
        Console.WriteLine("========");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
    case 10:
        Console.WriteLine("=======");
        Console.WriteLine("X CICLO");
        Console.WriteLine("=======");
        if (eleigeCategoria == 1)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_A;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * primerDescuento;
                mensualidad = categoria_A - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_A * segundoDescuento;
                mensualidad = categoria_A - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_A * tercerDescuento;
                mensualidad = categoria_A - descuento;
            }
            Console.WriteLine($"Estas en la categoria {primerCategoria}");
        }
        else if (eleigeCategoria == 2)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_B;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * primerDescuento;
                mensualidad = categoria_B - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_B * segundoDescuento;
                mensualidad = categoria_B - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_B * tercerDescuento;
                mensualidad = categoria_B - descuento;
            }
            Console.WriteLine($"Estas en la categoria {segundaCategoria}");
        }
        else if (eleigeCategoria == 3)
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_C;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * primerDescuento;
                mensualidad = categoria_C - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_C * segundoDescuento;
                mensualidad = categoria_C - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_C * tercerDescuento;
                mensualidad = categoria_C - descuento;
            }
            Console.WriteLine($"Estas en la categoria {terceraCategoria}");
        }
        else
        {
            if (ingreseNotas >= 0 && ingreseNotas <= 13.99)
            {
                nota = ingreseNotas;
                mensualidad = categoria_D;
            }
            else if (ingreseNotas >= 14 && ingreseNotas <= 15.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * primerDescuento;
                mensualidad = categoria_D - descuento;
            }
            else if (ingreseNotas >= 16 && ingreseNotas <= 17.99)
            {
                nota = ingreseNotas;
                descuento = categoria_D * segundoDescuento;
                mensualidad = categoria_D - descuento;
            }
            else
            {
                nota = ingreseNotas;
                descuento = categoria_D * tercerDescuento;
                mensualidad = categoria_D - descuento;
            }
            Console.WriteLine($"Estas en la categoria {cuartaCategoria}");
        }
        break;
}
Console.WriteLine($"Tu promedio ponderado del ciclo anterior es: {nota}");
Console.WriteLine($"Tienes un descuento de: S/{descuento} soles.");
Console.WriteLine($"Tu mensualidad de este mes es de: S/{mensualidad} soles.");