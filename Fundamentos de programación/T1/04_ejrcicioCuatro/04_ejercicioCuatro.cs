// See https://aka.ms/new-console-template for more information

double salarioBase, salarioBruto, tasaAdicional = 0, horasAdicionales = 0;
int categoria, aplicaFiscalizacion, fueraDeDomicilio;

Console.Write("Ingrese el sueldo base: ");
salarioBase = double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("==================");
    Console.Write("INGRESA CATEGORÍA.\n");
    Console.WriteLine("==================");
    Console.Write("[1] Costa.\n");
    Console.Write("[2] Sierra ≤ 2750 msnm.\n");
    Console.Write("[3] Sierra > 2750 msnm.\n");
    Console.Write("[4] Selva.\n");
    Console.WriteLine("=====================");
    Console.Write("Elige entre 1 - 4: ");
    categoria = int.Parse(Console.ReadLine());
    if (categoria < 1 || categoria > 4)
    {
        Console.WriteLine("\nERROR - Solo puedes ingresar del 1 - 4.\n");
    }
} while (categoria < 1 || categoria > 4);

do
{
    Console.Write("\n============================\n");
    Console.Write("ESTAS SUJETO A FISCALIZACIÓN\n");
    Console.Write("============================\n");
    Console.Write("[1] - SI.\n");
    Console.Write("[2] - NO.\n");
    Console.WriteLine("=====================");
    Console.Write("Elige entre 1 - 2: ");
    aplicaFiscalizacion = int.Parse(Console.ReadLine());
    if (aplicaFiscalizacion < 1 || aplicaFiscalizacion > 2)
    {
        Console.WriteLine("\nERROR - Solo puedes ingresar del 1 - 2.");
    }
} while (aplicaFiscalizacion < 1 || aplicaFiscalizacion > 2);

do
{
    Console.Write("\n===================================\n");
    Console.Write("¿TRABAJA EN SU LUGAR DE RESIDENCIA?");
    Console.Write("\n===================================\n");
    Console.Write("[1] - SI.\n");
    Console.Write("[2] - NO.\n");
    Console.WriteLine("=====================");
    Console.Write("Elige entre 1 - 2: ");
    fueraDeDomicilio = int.Parse(Console.ReadLine());
    if (fueraDeDomicilio < 1 || fueraDeDomicilio > 2)
    {
        Console.WriteLine("\nERROR - Solo puedes ingresar del 1 - 2.");
    }
} while (fueraDeDomicilio < 1 || fueraDeDomicilio > 2);


if (aplicaFiscalizacion == 0)
{
    switch (categoria)
    {
        case 1:
            tasaAdicional = 0.15;
            break;
        case 2:
            tasaAdicional = 0.25;
            break;
        case 3:
            tasaAdicional = 0.30;
            break;
        case 4:
            tasaAdicional = 0.20;
            break;
    }
    salarioBruto = salarioBase + (salarioBase * tasaAdicional);
}
else
{
    switch (categoria)
    {
        case 1:
            horasAdicionales = 29;
            break;
        case 2:
            horasAdicionales = 48;
            break;
        case 3:
            horasAdicionales = 58;
            break;
        case 4:
            horasAdicionales = 38.5;
            break;
    }

    if (fueraDeDomicilio == 1)
    {
        salarioBruto = salarioBase + horasAdicionales * salarioBase * 0.25;
    }
    else
    {
        salarioBruto = salarioBase;
    }
}
Console.WriteLine("\n=====================================");
Console.WriteLine($"El sueldo bruto es de: S/{salarioBruto} soles.");
Console.WriteLine("=====================================");