// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo 2 - Semana 3");

double sueldo, bono;
int genero, categoria;

Console.Write("Ingrese el sueldo del trabajador: ");
sueldo = Convert.ToDouble(Console.ReadLine());

do
{
    Console.Write("Seleccione el genero: [1] Hombre - [2] Mujer: ");
    genero = Convert.ToInt32(Console.ReadLine());
} while (genero != 1 && genero != 2);

do
{
    Console.Write("Seleccione la categoria del trabajador [1] Obrero - [2] Empleado: ");
    categoria = Convert.ToInt32(Console.ReadLine());
} while (categoria != 1 && categoria != 2);

if (genero == 1)

{
    if (categoria == 1)
    {
        bono = sueldo * 0.1;
    }
    else
    {
        bono = sueldo * 0.15;
    }
}

else
{
    if (categoria == 1)
    {
        bono = sueldo * 0.15;
    }
    else
    {
        bono = sueldo * 0.2;
    }
}

Console.WriteLine("El bono del trabajaor será: " + bono + " soles");
Console.WriteLine("El sueldo bruto del trabajaor será: " + (sueldo + bono) + " soles");



Console.ReadKey();
