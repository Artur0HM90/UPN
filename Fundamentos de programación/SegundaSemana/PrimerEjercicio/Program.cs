// See https://aka.ms/new-console-template for more information

// crear programas, desarrollar algoritmos, construir software

Console.WriteLine("Hola numdo, este es mi primer programa\n");
Console.WriteLine("Estudio en la UPN - Ciclo 2024 - 2");
Console.WriteLine("----------------------------------------\n");
Console.WriteLine("Ejemplo 1 - Calcular el IMC");

//conecte a la base de datos
// El usuario ingrese los datos por teclado


// Entrada
double peso, talla, IMC;


Console.Write("Ingrese su pero: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese su talla: ");
talla = Convert.ToDouble(Console.ReadLine());

// Proceso
IMC = peso / (talla * talla);
IMC = Math.Round(IMC, 2);

// Salida
Console.WriteLine($"Con su peso ingresado: {peso} y su talla indicada {talla} metros.");
Console.WriteLine($"Su indice de masa corparal es {IMC}");



Console.ReadKey();