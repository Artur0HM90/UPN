// See https://aka.ms/new-console-template for more information
/*
Construya el siguiente programa. Calcular el perímetro y el área de un círculo, sabiendo que su fórmula es:
                                        Perimetro=2 * π * radio

                                            Area=π* (radio)^2
*/


int radioDelCirculo;
double PI = 3.1416, perimetro, area;


Console.Write("Ingresa el radio del circulo: ");
radioDelCirculo = Convert.ToInt32(Console.ReadLine());

perimetro = (2 * PI) * radioDelCirculo;
area = Math.PI * Math.Pow(radioDelCirculo, 2);


Console.WriteLine($"El perimetro es: {perimetro} cm.");
Console.WriteLine($"El área del circulo es: {area:F3} cm2.");