// See https://aka.ms/new-console-template for more information
/*
En un hospital se ha hecho un estudio sobre los pacientes registrados durante los últimos 10 años, con el objetivo de hacer una aproximación de los costos de internación por paciente.
Se obtuvo un costo promedio diario según el tipo de enfermedad que aqueja al paciente.
Además, se pudo determinar que en promedio todos los pacientes con edad entre 14 y 22 años implican un costo adicional del 10%. La siguiente tabla expresa los costos diarios según el tipo de enfermedad.

Tipo de enfermedad         Costo paciente por día
1                                       25
------------------------------------------
2                                       16
------------------------------------------
3                                       20
------------------------------------------
4                                       32
------------------------------------------
cualquier otra enfermedad               20
------------------------------------------
*/


int primeraEnfermedad = 25, segundaEnfermedad = 16, terceraEmfermedad = 20, cuartaEnfermedad = 32, otrasEnfermedades = 20;
int ingresaCategoriaDeEnfermedad, ingresaEdad, cuantosDiasInternado, costoTotalPorInternacion;
double costoAdicional = 0.10, totalConElCostoAdicional;

do
{
    Console.WriteLine("Ingresa edad: ");
    Console.WriteLine("1. Enfermedad");
    Console.WriteLine("2. Enfermedad");
    Console.WriteLine("3. Enfermedad");
    Console.WriteLine("4. Enfermedad");
    Console.WriteLine("5. Otras Enfermedad");
    Console.Write("Elige entre 1 - 5: ");
    ingresaCategoriaDeEnfermedad = Convert.ToInt32(Console.ReadLine());
} while ((ingresaCategoriaDeEnfermedad != 1) && (ingresaCategoriaDeEnfermedad != 2) && (ingresaCategoriaDeEnfermedad != 3) && (ingresaCategoriaDeEnfermedad != 4) && (ingresaCategoriaDeEnfermedad != 5));

do
{
    Console.Write("Ingresa la edad del paciente: ");
    ingresaEdad = Convert.ToInt32(Console.ReadLine());
} while (ingresaEdad < 0);

do
{
    Console.Write("Ingresa cuantos dias esta internado: ");
    cuantosDiasInternado = Convert.ToInt32(Console.ReadLine());
} while (cuantosDiasInternado < 0);


switch (ingresaCategoriaDeEnfermedad)
{
    case 1:
        Console.WriteLine($"Elegiste {ingresaCategoriaDeEnfermedad} enfermedad.");
        if ((ingresaEdad >= 0) && (ingresaEdad <= 13))
        {
            costoTotalPorInternacion = cuantosDiasInternado * primeraEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        else if ((ingresaEdad >= 14) && (ingresaEdad <= 22))
        {
            costoTotalPorInternacion = cuantosDiasInternado * primeraEnfermedad;
            totalConElCostoAdicional = costoTotalPorInternacion * costoAdicional;
            Console.WriteLine($"Tienen {ingresaEdad} años");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
            Console.WriteLine($"Hay un costo adicional del 10% que es de {totalConElCostoAdicional} dolares.");
            Console.WriteLine($"Total a pagar por los {cuantosDiasInternado} dias internado es de: {costoTotalPorInternacion + totalConElCostoAdicional} dolares.");
        }
        else
        {
            costoTotalPorInternacion = cuantosDiasInternado * primeraEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        break;

    case 2:
        Console.WriteLine($"Elegiste {ingresaCategoriaDeEnfermedad} enfermedad.");
        if ((ingresaEdad >= 0) && (ingresaEdad <= 13))
        {
            costoTotalPorInternacion = cuantosDiasInternado * segundaEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        else if ((ingresaEdad >= 14) && (ingresaEdad <= 22))
        {
            costoTotalPorInternacion = cuantosDiasInternado * segundaEnfermedad;
            totalConElCostoAdicional = costoTotalPorInternacion * costoAdicional;
            Console.WriteLine($"Tienen {ingresaEdad} años");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
            Console.WriteLine($"Hay un costo adicional del 10% que es de {totalConElCostoAdicional} dolares.");
            Console.WriteLine($"Total a pagar por los {cuantosDiasInternado} dias internado es de: {costoTotalPorInternacion + totalConElCostoAdicional} dolares.");
        }
        else
        {
            costoTotalPorInternacion = cuantosDiasInternado * segundaEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        break;

    case 3:
        Console.WriteLine($"Elegiste {ingresaCategoriaDeEnfermedad} enfermedad.");
        if ((ingresaEdad >= 0) && (ingresaEdad <= 13))
        {
            costoTotalPorInternacion = cuantosDiasInternado * terceraEmfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        else if ((ingresaEdad >= 14) && (ingresaEdad <= 22))
        {
            costoTotalPorInternacion = cuantosDiasInternado * terceraEmfermedad;
            totalConElCostoAdicional = costoTotalPorInternacion * costoAdicional;
            Console.WriteLine($"Tienen {ingresaEdad} años");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
            Console.WriteLine($"Hay un costo adicional del 10% que es de {totalConElCostoAdicional} dolares.");
            Console.WriteLine($"Total a pagar por los {cuantosDiasInternado} dias internado es de: {costoTotalPorInternacion + totalConElCostoAdicional} dolares.");
        }
        else
        {
            costoTotalPorInternacion = cuantosDiasInternado * terceraEmfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        break;

    case 4:
        Console.WriteLine($"Elegiste {ingresaCategoriaDeEnfermedad} enfermedad.");
        if ((ingresaEdad >= 0) && (ingresaEdad <= 13))
        {
            costoTotalPorInternacion = cuantosDiasInternado * cuartaEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        else if ((ingresaEdad >= 14) && (ingresaEdad <= 22))
        {
            costoTotalPorInternacion = cuantosDiasInternado * cuartaEnfermedad;
            totalConElCostoAdicional = costoTotalPorInternacion * costoAdicional;
            Console.WriteLine($"Tienen {ingresaEdad} años");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
            Console.WriteLine($"Hay un costo adicional del 10% que es de {totalConElCostoAdicional} dolares.");
            Console.WriteLine($"Total a pagar por los {cuantosDiasInternado} dias internado es de: {costoTotalPorInternacion + totalConElCostoAdicional} dolares.");
        }
        else
        {
            costoTotalPorInternacion = cuantosDiasInternado * cuartaEnfermedad;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        break;

    case 5:
        Console.WriteLine($"Elegiste {ingresaCategoriaDeEnfermedad} enfermedad.");
        if ((ingresaEdad >= 0) && (ingresaEdad <= 13))
        {
            costoTotalPorInternacion = cuantosDiasInternado * otrasEnfermedades;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        else if ((ingresaEdad >= 14) && (ingresaEdad <= 22))
        {
            costoTotalPorInternacion = cuantosDiasInternado * otrasEnfermedades;
            totalConElCostoAdicional = costoTotalPorInternacion * costoAdicional;
            Console.WriteLine($"Tienen {ingresaEdad} años");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
            Console.WriteLine($"Hay un costo adicional del 10% que es de {totalConElCostoAdicional} dolares.");
            Console.WriteLine($"Total a pagar por los {cuantosDiasInternado} dias internado es de: {costoTotalPorInternacion + totalConElCostoAdicional} dolares.");
        }
        else
        {
            costoTotalPorInternacion = cuantosDiasInternado * otrasEnfermedades;
            Console.WriteLine($"Tienen {ingresaEdad} años ");
            Console.WriteLine($"{cuantosDiasInternado} dias internados el costo es de : {costoTotalPorInternacion} dolares.");
        }
        break;

    default:
        Console.WriteLine("ERROR - Elige entre 1 - 5.");
        break;
}