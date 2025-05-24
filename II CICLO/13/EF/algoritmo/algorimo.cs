
Console.Write("Ingrese el número de elementos en los arreglos: ");
int n = int.Parse(Console.ReadLine());

if (n < 2)
{
    Console.WriteLine("Se necesitan al menos dos puntos para calcular una recta.");
    return;
}

double[] x = new double[n];
double[] y = new double[n];

Console.Write("Ingrese los valores de x: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"x[{i}]: ");
    x[i] = double.Parse(Console.ReadLine());
}

Console.Write("\nIngrese los valores de y: ");
for (int i = 0; i < n; i++)
{
    Console.Write($"y[{i}]: ");
    y[i] = double.Parse(Console.ReadLine());
}

double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
for (int i = 0; i < n; i++)
{
    sumX += x[i];
    sumY += y[i];
    sumXY += x[i] * y[i];
    sumX2 += x[i] * x[i];
}

double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
double b = (sumY - a * sumX) / n;

Console.WriteLine($"\nLa ecuación de la recta de regresión es: y = {a:F2}x + {b:F2}");

Console.Write("\nIngrese el valor de x para calcular y: ");
double xConocido = double.Parse(Console.ReadLine());
double yResultado = a * xConocido + b;

Console.WriteLine($"Para x = {xConocido}, y = {yResultado:F2}");
