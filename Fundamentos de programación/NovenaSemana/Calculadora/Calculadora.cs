internal class Program
{
    public static double ingresaPrimerNumero, ingresaSegundoNumero;

    private static void Main(string[] args)
    {
        Console.WriteLine("Usando bibliotecas");
        double resultado = 0;
        int operador;
        do
        {
            Console.WriteLine("Seleccione una operacion: ");
            Console.WriteLine("1) Suma.");
            Console.WriteLine("2) Resta.");
            Console.WriteLine("3) Multiplicación.");
            Console.WriteLine("4) División.");
            Console.Write("Ingresa un número del 1 - 4: ");
            operador = Convert.ToInt32(Console.ReadLine());
            if (operador <= 0 || operador >= 5)
            {
                Console.WriteLine("\nERROR - Debes ingresar del 1 - 4.\n");
            }
        } while (operador <= 0 || operador >= 5);
        solicitarValores();
        switch (operador)
        {
            case 1:
                resultado = MiBiblioteca.MisFunciones.Sumar(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case 2:
                resultado = MiBiblioteca.MisFunciones.Resta(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case 3:
                resultado = MiBiblioteca.MisFunciones.Multiplicacion(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case 4:
                resultado = MiBiblioteca.MisFunciones.Division(ingresaPrimerNumero, ingresaSegundoNumero);
                break;
        }

        Console.WriteLine($"El resultado es: {resultado:F0}");

        static void solicitarValores()
        {
            Console.Write("Ingresa el primer número: ");
            ingresaPrimerNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segunndo número: ");
            ingresaSegundoNumero = Convert.ToDouble(Console.ReadLine());
        }
    }
}