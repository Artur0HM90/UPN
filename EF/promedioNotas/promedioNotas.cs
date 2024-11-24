class Program
{
    static double primeraNota(double notaUno) => notaUno * 0.10;
    static double segundaNota(double notaDos) => notaDos * 0.10;
    static double terceraNota(double notaTres) => notaTres * 0.10;
    static double cuartaNota(double notaCuarta) => notaCuarta * 0.30;
    static double quintaNota(double notaQuinta) => notaQuinta * 0.40;

    static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        double notaT1, notaT2, notaT3, notaEP, notaEF, promedio;
        int cantidadDeEstudiantes;
        do
        {
            Console.Write("Ingresa cuántos estudiantes son: ");
            cantidadDeEstudiantes = Convert.ToInt32(Console.ReadLine());
            if (cantidadDeEstudiantes < 1)
            {
                Console.WriteLine("\nDebes ingresar mayor a 1.\n");
            }
        } while (cantidadDeEstudiantes < 1);

        Console.Clear();

        for (int i = 1; i <= cantidadDeEstudiantes; i++)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("INGRESA NOMBRE DE LOS ESTUDIANTES");
            Console.WriteLine("==================================");
            Console.Write($"Ingresa el {i} nombre: ");
            string nombre = Console.ReadLine().ToUpper();

            Console.WriteLine("\n-----------------");
            Console.WriteLine("Ingresa las notas");
            Console.WriteLine("-----------------");

            Console.Write("Ingresa la nota del T1: ");
            notaT1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota del T2: ");
            notaT2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota del T3: ");
            notaT3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota del EP: ");
            notaEP = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota del EF: ");
            notaEF = Convert.ToDouble(Console.ReadLine());

            promedio = primeraNota(notaT1) + segundaNota(notaT2) + terceraNota(notaT3) + cuartaNota(notaEP) + quintaNota(notaEF);

            estudiantes.Add(new Estudiante
            {
                Nombre = nombre,
                T1 = primeraNota(notaT1),
                T2 = segundaNota(notaT2),
                T3 = terceraNota(notaT3),
                EP = cuartaNota(notaEP),
                EF = quintaNota(notaEF),
                Promedio = promedio
            });

            Console.Clear();
        }

        Console.WriteLine("===============");
        Console.WriteLine("PROMEDIO FINAL");
        Console.WriteLine("===============");
        Console.WriteLine("Nombres".PadRight(15) + "T1(10 %)".PadRight(10) + "T2(10 %)".PadRight(10) + "T3(10 %)".PadRight(10) + "EP(30 %)".PadRight(10) + "EF(40 %)".PadRight(10) + "Promedio".PadRight(10));
        Console.WriteLine("==============================================================================");

        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Promedio <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ResetColor();
            }
            Console.WriteLine($"{estudiante.Nombre,-10} {estudiante.T1,10:F2} {estudiante.T2,10:F2} {estudiante.T3,10:F2} {estudiante.EP,10:F2} {estudiante.EF,10:F2} {estudiante.Promedio,10:F}");
        }
        Console.ResetColor();
    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public double T1 { get; set; }
        public double T2 { get; set; }
        public double T3 { get; set; }
        public double EP { get; set; }
        public double EF { get; set; }
        public double Promedio { get; set; }
    }
}

