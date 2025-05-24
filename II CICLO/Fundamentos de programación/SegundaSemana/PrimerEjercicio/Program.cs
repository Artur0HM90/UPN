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

if (IMC < 18.5)
{
    Console.WriteLine($"Su IMC es {IMC} -> esta bajo de peso.");
}
else if (IMC < 24.9)
{
    Console.WriteLine($"Su IMC es {IMC} -> Su peso es saludable.");
}
else if (IMC < 29.9)
{
    Console.WriteLine($"Su IMC es {IMC} -> Tiene sobre peso.");
}
else
{
    Console.WriteLine($"Su IMC es {IMC} -> Tiene obesidad.");
    if (IMC < 34.9)
    {
        Console.WriteLine("Riesgo bajo.");
    }
    else if (IMC < 39.9)
    {
        Console.WriteLine("Riesgo moderado.");
    }
    else
    {
        Console.WriteLine("Riesgo alto.");
    }
}




Console.ReadKey();