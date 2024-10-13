namespace ejercicioconbiblioteca;

public class Class1
{
using System;

namespace MiBiblioteca

{

    public class MisFunciones

    {

        public static void MetodoCirculo(double radio, out double area, out double perimetro)

        {

            area = Math.PI * Math.Pow(radio, 2);

            perimetro = 2 * Math.PI * radio;

        }



        // Método para calcular el área y perímetro de un cuadrado

        public static void MetodoCuadrado(double lado, out double area, out double perimetro)

        {

            area = Math.Pow(lado, 2);

            perimetro = 4 * lado;

        }



        // Método para calcular el área y perímetro de un rectángulo

        public static void MetodoRectangulo(double largo, double ancho, out double area, out double perimetro)

        {

            area = largo * ancho;

            perimetro = 2 * (largo + ancho);

        }



        // Método para calcular el área y perímetro de un rombo

        public static void MetodoRombo(double diagonalMayor, double diagonalMenor, double lado, out double area, out double perimetro)

        {

            area = (diagonalMayor * diagonalMenor) / 2;

            perimetro = 4 * lado;

        }



        // Método para calcular el área y perímetro de un trapecio

        public static void MetodoTrapecio(double baseMayor, double baseMenor, double altura, double lado1, double lado2, out double area, out double perimetro)

        {

            area = ((baseMayor + baseMenor) / 2) * altura;

            perimetro = baseMayor + baseMenor + lado1 + lado2;

        }



        public static double Sumar(double num1, double num2)

        {

            return num1 + num2;

        }

        public static double Resta(double num1, double num2)

        {

            return num1 - num2;

        }

        public static double Producto(double num1, double num2)

        {

            return num1 * num2;

        }

        public static double Division(double num1, double num2)

        {

            if (num2 != 0)

            {

                return num1 / num2;

            }

            else

            {

                Console.WriteLine("La division por 0 no se puede");

                return 0;

            }

        }





    }

}
}
