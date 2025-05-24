using System;
using
internal class Program
{
    private static void Main(string[] args)
    {
        int elegirHabitacion, numeroDeHuespedes = 0, numeroDeDiasAlojados = 0, resultado = 0;
        int precioHabitacionIndividual = 150, precioHabitacionDoble = 280, precioHabitacionMatrimonial = 250, precioHabitacionSuite = 350; //tarifaAdicionalPorPersona = 120;

        do
        {
            do
            {
                Console.WriteLine("Elige que habitación deseas: ");
                Console.WriteLine("[1] Habitacion Individual.");
                Console.WriteLine("[2] Habitacion Doble.");
                Console.WriteLine("[3] Habitacion Matrimonial.");
                Console.WriteLine("[4] Habitacion Suite.");
                Console.Write("Elige entre 1 - 4: ");
                elegirHabitacion = Convert.ToInt32(Console.ReadLine());
                if (elegirHabitacion < 1 || elegirHabitacion > 4)
                {
                    Console.WriteLine("\nNúmero de habitación no válido - Debes elegir entre el 1 - 4.\n");
                }
            } while (elegirHabitacion < 1 || elegirHabitacion > 4);

            Console.Write("Cuantos huespedes son: ");
            numeroDeHuespedes = Convert.ToInt32(Console.ReadLine());
            if (elegirHabitacion == 1 && numeroDeHuespedes > 1)
            {
                Console.WriteLine($"\nSon {numeroDeHuespedes} huespedes no puedes elegir la habitación individual elige otra habitación.\n");
            }

        } while (elegirHabitacion == 1 && numeroDeHuespedes > 1);

        Console.WriteLine("Cuantos dias se va aloja: ");
        numeroDeDiasAlojados = Convert.ToInt32(Console.ReadLine());

        switch (elegirHabitacion)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("HABITACIÓN INDIVIDUAL.");
                //resultado = MisHabitaciones.MiAlojamiento.habitacionIndividual(precioHabitacionIndividual, numeroDeDiasAlojados);
                resultado = misHabitaciones.MiAlojamiento.habitacionIndividual(precioHabitacionIndividual, numeroDeDiasAlojados)
                Console.ResetColor();
                break;

            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("HABITACIÓN DOBLE.");
                //resultado = MisHabitaciones.MiAlojamiento.habitacionIndividual(precioHabitacionDoble, numeroDeDiasAlojados);
                resultado = misHabitaciones.MiAlojamiento.habitacionDoble(precioHabitacionDoble, numeroDeDiasAlojados)
                Console.ResetColor();
                break;

            case 3:
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("HABITACIÓN MATRIMONIAL.");
                //resultado = MisHabitaciones.MiAlojamiento.habitacionIndividual(precioHabitacionMatrimonial, numeroDeDiasAlojados);
                resultado = misHabitaciones.MiAlojamiento.habitacionMatrimonial(precioHabitacionMatrimonial, numeroDeDiasAlojados)
                Console.ResetColor();
                break;

            case 4:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("HABITACIÓN SUITE.");
                //resultado = MisHabitaciones.MiAlojamiento.habitacionIndividual(precioHabitacionSuite, numeroDeDiasAlojados);
                resultado = misHabitaciones.MiAlojamiento.habitacionSuite(precioHabitacionSuite, numeroDeDiasAlojados)
                Console.ResetColor();
                break;
        }
    }
}