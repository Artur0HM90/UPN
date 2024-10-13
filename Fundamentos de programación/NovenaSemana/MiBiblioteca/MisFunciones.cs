namespace MiBiblioteca;

public class MisFunciones
{
    public static double Sumar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }
    public static double Resta(double numero1, double numero2)
    {
        return numero1 - numero2;
    }
    public static double Multiplicacion(double numero1, double numero2)
    {
        return numero1 * numero2;
    }
    public static double Division(double numero1, double numero2)
    {
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede dividir entre cero");
            return 0;
        }
        else
        {
            return numero1 / numero2;
        }
    }
}
