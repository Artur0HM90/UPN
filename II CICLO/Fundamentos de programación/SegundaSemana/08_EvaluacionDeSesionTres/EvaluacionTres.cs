// See https://aka.ms/new-console-template for more information
/*
3. Desarrollar el algoritmo que te permita ingresar un sueldo ficticio y calcular lo siguiente:
• Sueldo de María disminuyeron el 5% de inasistencias y le descontaron 25.
• Sueldo de Juan le incrementaron 23% por comisiones más 72 de horas extra.
• Sueldo de Patricio le incrementaron un 5% pero le descontaron 56.
Se pide mostrar el sueldo de cada empelado y la suma de sus sueldos.
*/


double ingresaSueldo;
double descuento, incremento, descuentoIncremento = 0.05, incrementoDeSueldo = 0.23, total;
int primerDesuento = 25, segundoDescuento = 56;

Console.Write("Ingresa sueldo de los trabajadores: ");
ingresaSueldo = Convert.ToDouble(Console.ReadLine());
descuento = ingresaSueldo * descuentoIncremento;
Console.WriteLine($"Tu sueldo es: {ingresaSueldo} dolares.");
Console.WriteLine($"Tienes un descuento del 5% de tu sueldo: {descuento} dolares.");
Console.WriteLine($"Tienes un descuento de {primerDesuento} dolares.");
total = ingresaSueldo - descuento - primerDesuento;
Console.WriteLine($"El sueldo de Maria este mes es: {total} dolares.");
Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Tu sueldo es: {ingresaSueldo} dolares.");
incremento = ingresaSueldo * incrementoDeSueldo;
Console.WriteLine($"Tienes un incremento del 23% por horas extras de tu sueldo: {incremento} dolares.");
total = ingresaSueldo + incremento;
Console.WriteLine($"El sueldo de Juan es de: {total} dolares.");
Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Tu sueldo es: {ingresaSueldo} dolares.");
incremento = ingresaSueldo * descuentoIncremento;
Console.WriteLine($"Tienes un incremento del 5% de tu sueldo: {incremento} dolares.");
total = ingresaSueldo + incremento - segundoDescuento;
Console.WriteLine($"Tienes un descuento del {segundoDescuento} dolares.");
Console.WriteLine($"El sueldo de Patricio es de: {total} dolares.");



