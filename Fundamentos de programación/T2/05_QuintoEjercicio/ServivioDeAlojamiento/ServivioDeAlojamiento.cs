// See https://aka.ms/new-console-template for more information
/*
int tipoDeHabitacion, cantidadDeHuespedes, cantidadDeNoches; // variables para ingresar datos
int precioHabitacionIndividual = 150, precioHabitacionDoble = 280, precioHabitacionMatrimonial = 250, precioHabitacionSuite = 350; // precios de habitacion
int habitacionIndividual = 7, habitacionDoble = 4, habitacionMatrimonial = 5, habitacionSuite = 3; // Cantidad de habitaciones

do
{
    Console.WriteLine("====================");
    Console.WriteLine("Elige la habitación");
    Console.WriteLine("====================");
    Console.WriteLine("[1] H. Individual.");
    Console.WriteLine("[2] H. Doble.");
    Console.WriteLine("[3] H. Matrimonial.");
    Console.WriteLine("[4] H. Suite.");
    Console.WriteLine("-------------------");
    Console.Write("Elige del 1 - 4: ");
    tipoDeHabitacion = Convert.ToInt32(Console.ReadLine());
    if (tipoDeHabitacion < 1 || tipoDeHabitacion > 4)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nDebes ingresar entre el 1 - 4.\n");
        Console.ResetColor();
    }
} while (tipoDeHabitacion < 1 || tipoDeHabitacion > 4);

do
{
    Console.Write("\nIngresa cuantos huéspedes son: ");
    cantidadDeHuespedes = Convert.ToInt32(Console.ReadLine());
} while (cantidadDeHuespedes < 1);

do
{
    if (cantidadDeHuespedes > 1)
    {
        Console.Write("\nIngresa cuantos noches se van hospedar: ");
    }
    else
    {
        Console.Write("\nIngresa cuantos noches se va a hospedar: ");
    }
    cantidadDeNoches = Convert.ToInt32(Console.ReadLine());
} while (cantidadDeNoches < 1);

switch (tipoDeHabitacion)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("HABITACIÓN INDIVIDUAL.");
        Console.ResetColor();

        break;
    case 2:
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("HABITACIÓN DOBLE.");
        Console.ResetColor();

        break;
    case 3:
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("HABITACIÓN MATRIMONIAL.");
        Console.ResetColor();

        break;
    case 4:
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("HABITACIÓN SUITE.");
        Console.ResetColor();

        break;
}
*/
class Program
{
    static void Main()
    {
        string tipoHabitacion;
        int huespedes, noches;
        double tarifa = 0, tarifaAdicional = 0;
        int capacidadMaxima = 0;

        Console.WriteLine("Ingrese el tipo de habitación (Individual, Doble, Matrimonial, Suite): ");
        tipoHabitacion = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de huéspedes: ");
        huespedes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de noches: ");
        noches = Convert.ToInt32(Console.ReadLine());

        switch (tipoHabitacion.ToLower())
        {
            case "individual":
                tarifa = 150;
                capacidadMaxima = 1;
                break;
            case "doble":
                tarifa = 280;
                capacidadMaxima = 2;
                break;
            case "matrimonial":
                tarifa = 350;
                capacidadMaxima = 2;
                break;
            case "suite":
                tarifa = 350;
                tarifaAdicional = 120;
                capacidadMaxima = 4;
                break;
            default:
                Console.WriteLine("Tipo de habitación no válido.");
                return;
        }

        if (huespedes > capacidadMaxima)
        {
            Console.WriteLine("No se puede alquilar la habitación, sobrepasa la capacidad máxima.");
        }
        else
        {
            double costoTotal = tarifa * noches;
            if (huespedes > 2 && tarifaAdicional > 0)
            {
                costoTotal += tarifaAdicional * (huespedes - 2) * noches;
            }

            Console.WriteLine($"El costo total es: S/{costoTotal}");
        }
    }
}