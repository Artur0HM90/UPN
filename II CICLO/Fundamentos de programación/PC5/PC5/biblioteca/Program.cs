// See https://aka.ms/new-console-template for more information
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

Presione Mayús + Tabulación para navegar por el historial de chat.

