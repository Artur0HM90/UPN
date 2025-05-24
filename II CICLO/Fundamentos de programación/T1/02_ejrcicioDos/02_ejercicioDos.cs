// See https://aka.ms/new-console-template for more information

double capitalInicial, tasaInteres, tiempoTrascurrido;
double montoFinal, gananciaFinal;

Console.Write("Ingrese el capital con el que vas a iniciar: ");
capitalInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el porcentaje de la tasa de interes: ");
tasaInteres = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo que vas ahorro pero en años: ");
tiempoTrascurrido = Convert.ToDouble(Console.ReadLine());

montoFinal = capitalInicial * Math.Pow(1 + tasaInteres / 100, tiempoTrascurrido);
gananciaFinal = montoFinal - capitalInicial;

Console.WriteLine($"El interés que ganaras sera ganado es: {gananciaFinal.ToString("F2")}");

Console.WriteLine("==========================");
Console.WriteLine($"Monto final es: {montoFinal.ToString("F2")}");
Console.WriteLine("==========================");

