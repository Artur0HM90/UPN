using System;
using AreaPerimetro;

class SistemaCalcula
{
    static void Main()
    {
        int opcion;
        do
        {
            // Mostrar opciones al usuario
            Console.Clear();
            Console.WriteLine("Seleccione la figura geométrica:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Rombo");
            Console.WriteLine("5. Trapecio");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese la opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Círculo
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    var resultadoCirculo = Calculos.MetodoCirculo(radio);
                    Console.WriteLine($"Área: {resultadoCirculo.area}, Perímetro: {resultadoCirculo.perimetro}");
                    break;

                case 2:
                    // Cuadrado
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    var resultadoCuadrado = Calculos.MetodoCuadrado(ladoCuadrado);
                    Console.WriteLine($"Área: {resultadoCuadrado.area}, Perímetro: {resultadoCuadrado.perimetro}");
                    break;

                case 3:
                    // Rectángulo
                    Console.Write("Ingrese la base del rectángulo: ");
                    double baseRect = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    double alturaRect = double.Parse(Console.ReadLine());
                    var resultadoRectangulo = Calculos.MetodoRectangulo(baseRect, alturaRect);
                    Console.WriteLine($"Área: {resultadoRectangulo.area}, Perímetro: {resultadoRectangulo.perimetro}");
                    break;

                case 4:
                    // Rombo
                    Console.Write("Ingrese la diagonal mayor del rombo: ");
                    double diagonalMayor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la diagonal menor del rombo: ");
                    double diagonalMenor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el lado del rombo: ");
                    double ladoRombo = double.Parse(Console.ReadLine());
                    var resultadoRombo = Calculos.MetodoRombo(diagonalMayor, diagonalMenor, ladoRombo);
                    Console.WriteLine($"Área: {resultadoRombo.area}, Perímetro: {resultadoRombo.perimetro}");
                    break;

                case 5:
                    // Trapecio
                    Console.Write("Ingrese la base mayor del trapecio: ");
                    double baseMayor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la base menor del trapecio: ");
                    double baseMenor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del trapecio: ");
                    double alturaTrapecio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el lado 1 del trapecio: ");
                    double lado1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el lado 2 del trapecio: ");
                    double lado2 = double.Parse(Console.ReadLine());
                    var resultadoTrapecio = Calculos.MetodoTrapecio(baseMayor, baseMenor, alturaTrapecio, lado1, lado2);
                    Console.WriteLine($"Área: {resultadoTrapecio.area}, Perímetro: {resultadoTrapecio.perimetro}");
                    break;

                case 6:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            // Esperar la entrada para continuar
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 6);
    }
}