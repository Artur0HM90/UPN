// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo 1 - Semana 3");
Console.WriteLine("La Langonsta Ahumada");
Console.WriteLine("====================");

int cantidad, precio;
double presupuesto, descuento;

Console.Write("Ingrese la cantidad de comensales: ");
cantidad = int.Parse(Console.ReadLine() ?? "0");

if (cantidad <= 200)

{
    precio = 95;
}

else if (cantidad > 200 && cantidad <= 300)

{
    precio = 85;
}

else

{
    precio = 75;
}

Console.WriteLine("\n__________________________________");
Console.WriteLine("El precio del banquete es: " + precio);
presupuesto = cantidad * precio;

if (presupuesto > 10000)

{
    descuento = 0.05 * presupuesto;
    Console.WriteLine("El descuento es: " + descuento);
    presupuesto = presupuesto - descuento;
}

Console.WriteLine("El presupuesto final del servicio es: " + presupuesto + " soles");
Console.WriteLine("____________________________________________");

Console.ReadKey();
