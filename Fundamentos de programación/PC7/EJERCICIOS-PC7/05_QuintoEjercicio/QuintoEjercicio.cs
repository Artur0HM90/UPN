// See https://aka.ms/new-console-template for more information

/*
1.	Un centro comercial ha decidido hacer un obsequio a los clientes cuyo importe total pagado es mayor de S/. 500. Para obtener el obsequio, el cliente debe extraer un bolo de una urna que contiene 50 bolos numerados del 1 al 50. Con el número del bolo, el obsequio se obtiene de la siguiente tabla:

Número del bolo         Obsequio
    10	                Una agenda
    20	                Un reloj
    30	                Una memoria USB
    40	                Un perfume
    50	                Una radio
    Otro	            Una pelota

Dado el importe total pagado y el número del bolo, diseñe un programa que determine el obsequio correspondiente.
*/

double importeDeCompra;
int saqueBola = 0;
string ragalo = " ";


Console.Write("Ingrese el importe total de tu compra: ");
importeDeCompra = Convert.ToInt32(Console.ReadLine());

if (importeDeCompra > 500)
{
    Console.WriteLine("==================================");
    Console.WriteLine("Felicitaciones - puedes participar");
    Console.WriteLine("==================================");

    Console.WriteLine("===================");
    Console.Write("Extrae una bola: ");
    saqueBola = Convert.ToInt32(Console.ReadLine());

    switch (saqueBola)
    {
        case 10:
            ragalo = "Una agenda";
            break;

        case 20:
            ragalo = "Un reloj";
            break;

        case 30:
            ragalo = "Una memoria USB";
            break;

        case 40:
            ragalo = "Un perfume";
            break;

        case 50:
            ragalo = "Una radio";
            break;

        default:
            ragalo = "Una pelota";
            break;
    }
    Console.WriteLine($"Has ganado {ragalo}");
}
else
{
    Console.WriteLine($"No puedes participar tu importe es S/.{importeDeCompra} soles, debe ser mayor a S/. 500 soles, para participar");
}
