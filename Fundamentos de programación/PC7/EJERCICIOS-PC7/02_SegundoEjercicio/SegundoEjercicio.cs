// See https://aka.ms/new-console-template for more information
/*
2.	Una empresa de préstamos tiene el siguiente esquema de cobros:

Monto del préstamo (S/.)	        Número de cuotas
    Hasta 5000	                            2
Más de 5000 hasta 10000	                    4
Más de 10000 hasta 15000	                6
Más de 15000	                            10

Si el monto del préstamo es mayor de S/. 10000, la empresa cobra 3% de interés mensual; en caso contrario, cobra 5% de interés mensual.

Dado el monto del préstamo de un cliente, diseñe un programa que determine el número de cuotas, el monto de la cuota mensual y el monto del interés total entre todas las cuotas.
*/

double ingreseMontoDelPrestamo, factor;
double tasaInteres, montoCuota, montoTotalPagado, interesTotal;
int numeroCuotas;

Console.Write("Ingresa el monto que te vas a prestar: ");
ingreseMontoDelPrestamo = Convert.ToDouble(Console.ReadLine());

// Determinación del número de cuotas y tasa de interés
if (ingreseMontoDelPrestamo <= 5000)
{
    numeroCuotas = 2;
    tasaInteres = 0.05;
}
else if (ingreseMontoDelPrestamo > 5000 && ingreseMontoDelPrestamo <= 10000)
{
    numeroCuotas = 4;
    tasaInteres = 0.05;
}
else if (ingreseMontoDelPrestamo > 10000 && ingreseMontoDelPrestamo <= 15000)
{
    numeroCuotas = 6;
    tasaInteres = 0.03;
}
else
{
    numeroCuotas = 10;
    tasaInteres = 0.03;
}

// La cuota mensual (M)
factor = Math.Pow(1 + tasaInteres, numeroCuotas);
montoCuota = (ingreseMontoDelPrestamo * tasaInteres * factor) / (factor - 1);

// Total a pagar (T)
montoTotalPagado = montoCuota * numeroCuotas;

// El interés total (I)
interesTotal = montoTotalPagado - ingreseMontoDelPrestamo;

// Resultados
Console.WriteLine($"Número de cuotas: {numeroCuotas}");
Console.WriteLine($"Monto de la cuota mensual: S/. {montoCuota:F2}");
Console.WriteLine($"Monto total pagado: S/. {montoTotalPagado:F2}");
Console.WriteLine($"Interés total: S/. {interesTotal:F2}");