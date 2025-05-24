namespace Mishabitaciones;

public class MisHabitaciones

{
    public static int habitacionIndividual(int precioHabitacion, int diasAlojados)
    {
        return precioHabitacion * diasAlojados;
    }

    public static int habitacionDoble(int precioHabitacion, int diasAlojados)
    {
        return precioHabitacion * diasAlojados;
    }

    public static int habitacionMatrimonial(int precioHabitacion, int diasAlojados)
    {
        return precioHabitacion * diasAlojados;
    }

    public static int habitacionSuite(int precioHabitacion, int diasAlojados, int tarifaAdicional, int personaExtras)
    {
        if (personaExtras > 0)
        {
            return (precioHabitacion * diasAlojados) + (tarifaAdicional * personaExtras);
        }
        else
        {
            return precioHabitacion * diasAlojados;
        }
    }
}
