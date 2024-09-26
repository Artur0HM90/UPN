// See https://aka.ms/new-console-template for more information
/*
Un banco al percatarse de que usted puede automatizar sus préstamos le piden que construya un pseudocódigo que le permita calcular capital final que se pagará por un préstamo usando el interés simple, para ello requiere de la siguiente fórmula:

C_f=C(1+Interes/100 Tiempo)
*/

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

/*
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