internal class Program
{
    public static double ingresaPrimerNumero, ingresaSegundoNumero;

    private static void Main(string[] args)
    {
        Console.WriteLine("Usando bibliotecas");
        double resultado = 0, resultadoResto = 0;
        char operadores;
        //int operador;
        // do
        //{
        Console.WriteLine("Seleccione una operacion: ");
        Console.WriteLine("1) Suma ingresa (+).");
        Console.WriteLine("2) Resta ingresa (-).");
        Console.WriteLine("3) Multiplicación ingresa (x).");
        Console.WriteLine("4) División ingresa (/).");
        Console.Write("Ingresa un número del 1 - 4: ");
        operadores = Console.ReadLine()[0];

        //operador = Convert.ToInt32(Console.ReadLine());
        /*
        if (operador <= 0 || operador >= 5)
        {
            Console.WriteLine("\nERROR - Debes ingresar del 1 - 4.\n");
        }
        */
        //} while (operador <= 0 || operador >= 5);
        solicitarValores();
        switch (operadores)
        {
            case '+':
                resultado = MiBiblioteca.MisFunciones.Sumar(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case '-':
                resultado = MiBiblioteca.MisFunciones.Resta(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case 'x':
                resultado = MiBiblioteca.MisFunciones.Multiplicacion(ingresaPrimerNumero, ingresaSegundoNumero);
                break;

            case '/':
                resultado = MiBiblioteca.MisFunciones.Division(ingresaPrimerNumero, ingresaSegundoNumero);
                resultadoResto = MiBiblioteca.MisFunciones.Resto(ingresaPrimerNumero, ingresaSegundoNumero);
                break;
        }

        Console.WriteLine($"El resultado es: {resultado:F0}");
        if (resultadoResto > 0)
        {
            Console.WriteLine($"El resto es: {resultadoResto:F0}");
        }


        static void solicitarValores()
        {
            Console.Write("Ingresa el primer número: ");
            ingresaPrimerNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segunndo número: ");
            ingresaSegundoNumero = Convert.ToDouble(Console.ReadLine());
        }
    }
}