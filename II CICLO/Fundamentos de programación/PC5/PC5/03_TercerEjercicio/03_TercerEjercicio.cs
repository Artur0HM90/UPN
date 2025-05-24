// See https://aka.ms/new-console-template for more information
/*
Un banco al percatarse de que usted puede automatizar sus préstamos le piden que construya un pseudocódigo que le permita calcular capital final que se pagará por un préstamo usando el interés simple, para ello requiere de la siguiente fórmula:

C_f=C(1+Interes/100 Tiempo)
*/
/*
double capital, interes, tiempo, capitalFinal;

do
{
    Console.Write("Ingresa el momto del prestamo: ");
    capital = Convert.ToDouble(Console.ReadLine());
    if (capital <= 0)
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("El prestamo debe ser mayor a cero");
        Console.WriteLine("==================================\n");
    }
} while (capital <= 0);

do
{
    Console.Write("\nIngresa el interes anual: ");
    interes = Convert.ToDouble(Console.ReadLine());
    if (interes <= 0)
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("El interes debe ser mayor a cero");
        Console.WriteLine("==================================\n");
    }
} while (interes <= 0);

do
{
    Console.Write("\nIngresa tiempo a pagar en años: ");
    tiempo = Convert.ToDouble(Console.ReadLine());
    if (tiempo <= 0)
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("El tiempo debe ser mayor a cero");
        Console.WriteLine("==================================\n");
    }
} while (tiempo <= 0);


capitalFinal = capital * (1 + (interes / 100) * tiempo);

Console.WriteLine($"\ncapital final es de S/{capitalFinal} soles.");

/* seudocódigo
Algoritmo CalculoPrestamo
	
    Definir capital, interes, tiempo, capitalFinal Como Real
	
    Repetir
        Escribir "Ingresa el monto del préstamo: "
        Leer capital
        Si capital <= 0 Entonces
            Escribir "=================================="
            Escribir "El préstamo debe ser mayor a cero"
            Escribir "=================================="
        FinSi
    Hasta Que capital > 0
	
    Repetir
        Escribir "Ingresa el interés anual: "
        Leer interes
        Si interes <= 0 Entonces
            Escribir "=================================="
            Escribir "El interés debe ser mayor a cero"
            Escribir "=================================="
        FinSi
    Hasta Que interes > 0
	
    Repetir
        Escribir "Ingresa el tiempo a pagar en años: "
        Leer tiempo
        Si tiempo <= 0 Entonces
            Escribir "=================================="
            Escribir "El tiempo debe ser mayor a cero"
            Escribir "=================================="
        FinSi
    Hasta Que tiempo > 0
	
    capitalFinal = capital * (1 + (interes / 100) * tiempo)
	
    Escribir "El capital final es de ", capitalFinal, " soles."
	
FinAlgoritmo


*/
/*
const double PI = 3.1416; // Constante para el valor de π
double radio, perimetro, area;

Console.Write("Ingrese el radio del círculo: ");
radio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * radio;
area = PI * Math.Pow(radio, 2);

Console.WriteLine("El perímetro del círculo es: " + perimetro);
Console.WriteLine("El área del círculo es: " + area);


int categoria_A, categoria_B, categoria_C, categoria_D;
double primerDescuento, segundoDescuento, tercerDescuento;
int ingresaCiclo, eleigeCategoria;
double ingreseNotas, nota, mensualidad, descuento;

// Inicialización de las categorías y descuentos
categoria_A = 550;
categoria_B = 500;
categoria_C = 460;
categoria_D = 400;
primerDescuento = 0.10;
segundoDescuento = 0.12;
tercerDescuento = 0.15;
descuento = 0;

// Ciclo para elegir el ciclo
Console.WriteLine("Elige en qué ciclo estás (1 - 10):");
ingresaCiclo = Convert.ToInt32(Console.ReadLine());

while (ingresaCiclo < 1 || ingresaCiclo > 10)
{
    Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 10.");
    Console.WriteLine("Elige en qué ciclo estás (1 - 10):");
    ingresaCiclo = Convert.ToInt32(Console.ReadLine());
}

// Ciclo para elegir la categoría
do
{
    Console.WriteLine("=====================");
    Console.WriteLine("Elige tu categoría:");
    Console.WriteLine("=====================");
    for (int i = 1; i <= 4; i++)
    {
        Console.WriteLine($"[{i}] Categoría {i}.");
    }

    Console.Write("Elige entre 1 - 4: ");
    eleigeCategoria = Convert.ToInt32(Console.ReadLine());

    while (eleigeCategoria < 1 || eleigeCategoria > 4)
    {
        Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 4.");
        Console.Write("Elige entre 1 - 4: ");
        eleigeCategoria = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Ingrese la nota del alumno: ");
    ingreseNotas = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"========={ingresaCiclo} CICLO=========");

    // Cálculo de mensualidad y descuentos
    if (eleigeCategoria == 1)
    {
        mensualidad = categoria_A;
    }
    else if (eleigeCategoria == 2)
    {
        mensualidad = categoria_B;
        int categoria_A, categoria_B, categoria_C, categoria_D;
        double primerDescuento, segundoDescuento, tercerDescuento;
        int ingresaCiclo, eleigeCategoria;
        double ingreseNotas, nota, mensualidad, descuento;

        // Inicialización de las categorías y descuentos
        categoria_A = 550;
        categoria_B = 500;
        categoria_C = 460;
        categoria_D = 400;
        primerDescuento = 0.10;
        segundoDescuento = 0.12;
        tercerDescuento = 0.15;
        descuento = 0;

        // Ciclo para elegir el ciclo
        Console.WriteLine("Elige en qué ciclo estás (1 - 10):");
        ingresaCiclo = Convert.ToInt32(Console.ReadLine());

        while (ingresaCiclo < 1 || ingresaCiclo > 10)
        {
            Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 10.");
            Console.WriteLine("Elige en qué ciclo estás (1 - 10):");
            ingresaCiclo = Convert.ToInt32(Console.ReadLine());
        }

        // Ciclo para elegir la categoría
        do
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Elige tu categoría:");
            Console.WriteLine("=====================");
            Console.WriteLine("[1] Categoría A.");
            Console.WriteLine("[2] Categoría B.");
            Console.WriteLine("[3] Categoría C.");
            Console.WriteLine("[4] Categoría D.");

            Console.Write("Elige entre 1 - 4: ");
            eleigeCategoria = Convert.ToInt32(Console.ReadLine());

            while (eleigeCategoria < 1 || eleigeCategoria > 4)
            {
                Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 4.");
                Console.Write("Elige entre 1 - 4: ");
                eleigeCategoria = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Ingrese la nota del alumno: ");
            ingreseNotas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"========={ingresaCiclo} CICLO=========");


            // Cálculo de mensualidad y descuentos
            if (eleigeCategoria == 1)
            {
                mensualidad = categoria_A;
                Console.WriteLine("Has elegido Categoría A.");
            }
            else if (eleigeCategoria == 2)
            {
                mensualidad = categoria_B;
                Console.WriteLine("Has elegido Categoría B.");
                int categoria_A, categoria_B, categoria_C, categoria_D;
                double primerDescuento, segundoDescuento, tercerDescuento;
                int ingresaCiclo, eleigeCategoria;
                double ingreseNotas, nota, mensualidad, descuento;

                // Inicialización de las categorías y descuentos
                categoria_A = 550;
                categoria_B = 500;
                categoria_C = 460;
                categoria_D = 400;
                primerDescuento = 0.10;
                segundoDescuento = 0.12;
                tercerDescuento = 0.15;
                descuento = 0;

                // Ciclo para elegir el ciclo
                Console.WriteLine("Elige en qué ciclo estás 1 - 10:");
                ingresaCiclo = Convert.ToInt32(Console.ReadLine());

                while (ingresaCiclo < 1 || ingresaCiclo > 10)
                {
                    Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 10.");
                    Console.WriteLine("Elige en qué ciclo estás (1 - 10):");
                    ingresaCiclo = Convert.ToInt32(Console.ReadLine());
                }

                // Ciclo para elegir la categoría
                do
                {
                    Console.WriteLine("=====================");
                    Console.WriteLine("Elige tu categoría:");
                    Console.WriteLine("=====================");
                    Console.WriteLine("[1] Categoría A.");
                    Console.WriteLine("[2] Categoría B.");
                    Console.WriteLine("[3] Categoría C.");
                    Console.WriteLine("[4] Categoría D.");

                    Console.Write("Elige entre 1 - 4: ");
                    eleigeCategoria = Convert.ToInt32(Console.ReadLine());

                    while (eleigeCategoria < 1 || eleigeCategoria > 4)
                    {
                        Console.WriteLine("ERROR - Debes ingresar un número entre 1 - 4.");
                        Console.Write("Elige entre 1 - 4: ");
                        eleigeCategoria = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("Ingrese la nota del alumno: ");
                    ingreseNotas = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"========={ingresaCiclo} CICLO=========");

                    // Cálculo de mensualidad y descuentos
                    if (eleigeCategoria == 1)
                    {
                        mensualidad = categoria_A;
                        Console.WriteLine("Has elegido Categoría A.");
                    }
                    else if (eleigeCategoria == 2)
                    {
                        mensualidad = categoria_B;
                        Console.WriteLine("Has elegido Categoría B.");
                    }
                    else if (eleigeCategoria == 3)
                    {
                        mensualidad = categoria_C;
                        Console.WriteLine("Has elegido Categoría C.");
                    }
                    else
                    {
                        mensualidad = categoria_D;
                        Console.WriteLine("Has elegido Categoría D.");
                    }

                    // No aplicar descuento si es el primer ciclo
                    if (ingresaCiclo == 1)
                    {
                        descuento = 0;
                    }
                    else
                    {
                        if (ingreseNotas < 14)
                        {
                            descuento = 0;
                        }
                        else if (ingreseNotas < 16)
                        {
                            descuento = mensualidad * primerDescuento;
                        }
                        else if (ingreseNotas < 18)
                        {
                            descuento = mensualidad * segundoDescuento;
                        }
                        else
                        {
                            descuento = mensualidad * tercerDescuento;
                        }
                    }

                    // Resta el descuento de la mensualidad
                    mensualidad = mensualidad - descuento;

                    // Resultados
                    Console.WriteLine($"Tu promedio ponderado del ciclo anterior es: {ingreseNotas}");
                    Console.WriteLine($"Tienes un descuento de: S/{descuento} soles.");
                    Console.WriteLine($"Tu mensualidad de este mes es de {mensualidad} soles.");
                }
                while (false);







                // El bucle solo se ejecuta una vez, se puede ajustar }si es necesario


                */

using System.Timers;



internal class Program

{

    private static void Main(string[] args)

    {

        Console.WriteLine("Seleccione la figura para calcular (1: Círculo, 2: Cuadrado, 3: Rectángulo, 4: Rombo, 5: Trapecio):");

        int opcion = int.Parse(Console.ReadLine());



        double area, perimetro;



        switch (opcion)

        {

            case 1:

                Console.WriteLine("Ingrese el radio del círculo:");

                double radio = double.Parse(Console.ReadLine());

                MiBiblioteca.MisFunciones.MetodoCirculo(radio, out area, out perimetro);

                break;



            case 2:

                Console.WriteLine("Ingrese el lado del cuadrado:");

                double lado = double.Parse(Console.ReadLine());

                MiBiblioteca.MisFunciones.MetodoCuadrado(lado, out area, out perimetro);

                break;



            case 3:

                Console.WriteLine("Ingrese el largo del rectángulo:");

                double largo = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el ancho del rectángulo:");

                double ancho = double.Parse(Console.ReadLine());

                MiBiblioteca.MisFunciones.MetodoRectangulo(largo, ancho, out area, out perimetro);

                break;



            case 4:

                Console.WriteLine("Ingrese la diagonal mayor del rombo:");

                double diagonalMayor = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la diagonal menor del rombo:");

                double diagonalMenor = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado del rombo:");

                double ladoRombo = double.Parse(Console.ReadLine());

                MiBiblioteca.MisFunciones.MetodoRombo(diagonalMayor, diagonalMenor, ladoRombo, out area, out perimetro);

                break;



            case 5:

                Console.WriteLine("Ingrese la base mayor del trapecio:");

                double baseMayor = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la base menor del trapecio:");

                double baseMenor = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del trapecio:");

                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer lado del trapecio:");

                double lado1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo lado del trapecio:");

                double lado2 = double.Parse(Console.ReadLine());

                MiBiblioteca.MisFunciones.MetodoTrapecio(baseMayor, baseMenor, altura, lado1, lado2, out area, out perimetro);

                break;



            default:

                Console.WriteLine("Opción no válida.");

                return;

        }



        Console.WriteLine($"Área: {area}");

        Console.WriteLine($"Perímetro: {perimetro}");

    }

}