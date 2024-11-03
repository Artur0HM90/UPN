// See https://aka.ms/new-console-template for more information
int elegirRuta, elegirBus;

// distancias
int limaChimbote = 427, limaTrujillo = 556, limaChiclayo = 770, limaArequipa = 1011, limaTacna = 123;

// consumo por cada 100 Km - consumo de gasolina
double busDeCincuentaPasajeros = 5, busDeSesentaPasajeros = 6, busDeSetentaPasajeros = 6.5;

double consumoDeCombustible = 0, costoDelCombustible = 18.64;

// pagos del personal

double pagoPorPiloto = 12.25, pagoPorCopiloto = 10.50, pagoPorAyudante = 8.5;
int horasTrabajadasPiloto, horasTrabajadasCopiloto, horasTrabajadasAyudante;
double pagoPiloto, pagoCopiloto, pagoAyudante, pagoTotalAlPersonal = 0;

double CalcularConsumoGasolina(double distancia, double consumoPorCienKm)
{
    double tramos = distancia / 100;
    double consumoTotal = tramos * consumoPorCienKm;
    return consumoTotal;
}

double CalcularPagoPorPersonalPiloto(double horas, double pago)
{
    return horas * pago;
}
double CalcularPagoPorPersonalCopiloto(double horas, double pago)
{
    return horas * pago;
}
double CalcularPagoPorPersonalAyudante(double horas, double pago)
{
    return horas * pago;
}


do
{
    Console.WriteLine("==============");
    Console.WriteLine("ELIGE LA RUTA.");
    Console.WriteLine("==============");
    Console.WriteLine("[1] Lima - Chimbote.");
    Console.WriteLine("[2] Lima - Trujillo.");
    Console.WriteLine("[3] Lima - Chiclayo.");
    Console.WriteLine("[4] Lima - Arequipa.");
    Console.WriteLine("[5] Lima - Tacna.");
    Console.WriteLine("---------------------");
    Console.Write("Elige entre 1 - 5: ");

    elegirRuta = Convert.ToInt32(Console.ReadLine());
} while (elegirRuta < 1 || elegirRuta > 5);

do
{
    Console.WriteLine("\n==================");
    Console.WriteLine("ELIGE TIPO DE BUS.");
    Console.WriteLine("==================");
    Console.WriteLine("[1] Bus de 50 pasajeros.");
    Console.WriteLine("[2] Bus de 60 pasajeros.");
    Console.WriteLine("[3] Bus de 70 pasajeros.");
    Console.WriteLine("---------------------");
    Console.Write("Elige entre 1 - 3: ");
    elegirBus = Convert.ToInt32(Console.ReadLine());
} while (elegirBus < 1 || elegirBus > 3);

do
{
    Console.Write("\nCuantas horas trabajo el Piloto: ");
    horasTrabajadasPiloto = Convert.ToInt32(Console.ReadLine());
} while (horasTrabajadasPiloto < 1);

do
{
    Console.Write("\nCuantas horas trabajo el Copiloto: ");
    horasTrabajadasCopiloto = Convert.ToInt32(Console.ReadLine());
} while (horasTrabajadasCopiloto < 1);

do
{
    Console.Write("\nCuantas horas trabajo el Ayudante: ");
    horasTrabajadasAyudante = Convert.ToInt32(Console.ReadLine());
} while (horasTrabajadasAyudante < 1);

switch (elegirRuta)
{
    case 1:
        Console.WriteLine("\n=================");
        Console.WriteLine("Lima - Chimbote.");
        Console.WriteLine("=================");

        if (elegirBus == 1)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChimbote, busDeCincuentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 2)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChimbote, busDeSesentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 3)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChimbote, busDeSetentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        Console.WriteLine($"Haz recorrido una distancia de: {limaChimbote} Km.");
        break;
    case 2:
        Console.WriteLine("\n=================");
        Console.WriteLine("Lima - Trujillo.");
        Console.WriteLine("=================");

        if (elegirBus == 1)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTrujillo, busDeCincuentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 2)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTrujillo, busDeSesentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 3)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTrujillo, busDeSetentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        Console.WriteLine($"Haz recorrido una distancia de: {limaTrujillo} Km.");
        break;
    case 3:
        Console.WriteLine("=====================");
        Console.WriteLine("[3] Lima - Chiclayo.");
        Console.WriteLine("=====================");

        if (elegirBus == 1)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChiclayo, busDeCincuentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 2)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChiclayo, busDeSesentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 3)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaChiclayo, busDeSetentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        Console.WriteLine($"Haz recorrido una distancia de: {limaChiclayo} Km.");
        break;
    case 4:
        Console.WriteLine("\n=================");
        Console.WriteLine("Lima - Arequipa.");
        Console.WriteLine("=================");

        if (elegirBus == 1)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaArequipa, busDeCincuentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 2)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaArequipa, busDeSesentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 3)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaArequipa, busDeSetentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        Console.WriteLine($"Haz recorrido una distancia de: {limaArequipa} Km.");
        break;
    case 5:
        Console.WriteLine("\n==================");
        Console.WriteLine("[5] Lima - Tacna.");
        Console.WriteLine("==================");

        if (elegirBus == 1)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTacna, busDeCincuentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 2)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTacna, busDeSesentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        else if (elegirBus == 3)
        {
            consumoDeCombustible = CalcularConsumoGasolina(limaTacna, busDeSetentaPasajeros);
            pagoPiloto = CalcularPagoPorPersonalPiloto(horasTrabajadasPiloto, pagoPorPiloto);
            pagoCopiloto = CalcularPagoPorPersonalCopiloto(horasTrabajadasCopiloto, pagoPorCopiloto);
            pagoAyudante = CalcularPagoPorPersonalAyudante(horasTrabajadasAyudante, pagoPorAyudante);
            pagoTotalAlPersonal = pagoPiloto + pagoCopiloto + pagoAyudante;
        }
        Console.WriteLine($"Haz recorrido una distancia de: {limaTacna} Km.");
        break;

}

Console.WriteLine($"El consuma de combustible es de: {consumoDeCombustible:F2} galones.");
Console.WriteLine($"Costo del combustible por galon es de: S/{costoDelCombustible} soles.");
Console.WriteLine($"Costo total del consumo de combustible es: S/{costoDelCombustible * consumoDeCombustible + pagoTotalAlPersonal:F2} soles.");
Console.WriteLine("");