// See https://aka.ms/new-console-template for more information
/*
3.	Una dulcería vende chocolates a los precios dados en la siguiente tabla
Tipo de chocolate	Precio unitario
Primor	                S/. 8.5
Dulzura	                S/. 10.0
Tentación	            S/. 7.0
Explosión	            S/. 12.5

Como oferta, la tienda aplica un porcentaje de descuento sobre el importe de la compra, basándose en la cantidad de chocolates adquiridos, de acuerdo con la siguiente tabla:

Cantidad de chocolates	Descuento
    < 5	                  4.0%
≥ 5 y < 10	              6.5%
≥ 10 y < 15	              9.0%
    ≥ 15	             11.5%

Adicionalmente, si el importe a pagar es no menor de S/. 250, la tienda obsequia 3 caramelos por cada chocolate; en caso contrario, obsequia 2 caramelos por cada chocolate.

Dado el tipo de chocolate y la cantidad de unidades adquiridas, diseñe un programa que determine el importe de la compra, el importe del descuento, el importe a pagar y la cantidad de caramelos de obsequio.
*/

int cantidadChocolates, elegirChocolate, regaloCaramelos = 0;
int primerRegalo = 3, segundoRegalo = 2;
double precioPrimor = 8.5, precioDulzura = 10, precioTentación = 7, precioExplosión = 12.5;
double precio = 0, descuento = 0, totalPagar = 0;
double primerDescuento = 0.04, segundoDescuento = 0.065, tercerDescuento = 0.09, cuartoDescuento = 0.115;


do
{
    Console.WriteLine("Que tipo de chocolate vas a comprar.");
    Console.WriteLine("[1] Primor");
    Console.WriteLine("[2] Dulzura");
    Console.WriteLine("[3] Tentación");
    Console.WriteLine("[4] Explosión");
    Console.Write("Elige entre 1 - 4: ");
    elegirChocolate = Convert.ToInt32(Console.ReadLine());
} while (elegirChocolate <= 0 || elegirChocolate >= 5);


Console.Write("\nCuantos chocolates comprastes: ");
cantidadChocolates = Convert.ToInt32(Console.ReadLine());

if (elegirChocolate == 1)
{
    if (cantidadChocolates < 5)
    {
        precio = cantidadChocolates * precioPrimor;
        descuento = precio * primerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 5 && cantidadChocolates < 10)
    {
        precio = cantidadChocolates * precioPrimor;
        descuento = precio * segundoDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 10 && cantidadChocolates < 15)
    {
        precio = cantidadChocolates * precioPrimor;
        descuento = precio * tercerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else
    {
        precio = cantidadChocolates * precioPrimor;
        descuento = precio * cuartoDescuento;
        totalPagar = precio - descuento;
        if (totalPagar < 250)
        {
            regaloCaramelos = cantidadChocolates * segundoRegalo;
        }
        else
        {
            regaloCaramelos = cantidadChocolates * primerRegalo;
        }
    }
}
else if (elegirChocolate == 2)
{
    if (cantidadChocolates < 5)
    {
        precio = cantidadChocolates * precioDulzura;
        descuento = precio * primerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 5 && cantidadChocolates < 10)
    {
        precio = cantidadChocolates * precioDulzura;
        descuento = precio * segundoDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 10 && cantidadChocolates < 15)
    {
        precio = cantidadChocolates * precioDulzura;
        descuento = precio * tercerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else
    {
        precio = cantidadChocolates * precioDulzura;
        descuento = precio * cuartoDescuento;
        totalPagar = precio - descuento;
        if (totalPagar < 250)
        {
            regaloCaramelos = cantidadChocolates * segundoRegalo;
        }
        else
        {
            regaloCaramelos = cantidadChocolates * primerRegalo;
        }
    }
}
else if (elegirChocolate == 3)
{
    if (cantidadChocolates < 5)
    {
        precio = cantidadChocolates * precioTentación;
        descuento = precio * primerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 5 && cantidadChocolates < 10)
    {
        precio = cantidadChocolates * precioTentación;
        descuento = precio * segundoDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 10 && cantidadChocolates < 15)
    {
        precio = cantidadChocolates * precioTentación;
        descuento = precio * tercerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else
    {
        precio = cantidadChocolates * precioTentación;
        descuento = precio * cuartoDescuento;
        totalPagar = precio - descuento;
        if (totalPagar < 250)
        {
            regaloCaramelos = cantidadChocolates * segundoRegalo;
        }
        else
        {
            regaloCaramelos = cantidadChocolates * primerRegalo;
        }
    }
}
else
{
    if (cantidadChocolates < 5)
    {
        precio = cantidadChocolates * precioExplosión;
        descuento = precio * primerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 5 && cantidadChocolates < 10)
    {
        precio = cantidadChocolates * precioExplosión;
        descuento = precio * segundoDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else if (cantidadChocolates >= 10 && cantidadChocolates < 15)
    {
        precio = cantidadChocolates * precioExplosión;
        descuento = precio * tercerDescuento;
        totalPagar = precio - descuento;
        regaloCaramelos = cantidadChocolates * segundoRegalo;
    }
    else
    {
        precio = cantidadChocolates * precioExplosión;
        descuento = precio * cuartoDescuento;
        totalPagar = precio - descuento;
        if (totalPagar < 250)
        {
            regaloCaramelos = cantidadChocolates * segundoRegalo;
        }
        else
        {
            regaloCaramelos = cantidadChocolates * primerRegalo;
        }
    }
}

Console.WriteLine($"Precio del producto: S/.{precio:F2} soles.");
Console.WriteLine($"Tienes un descuento de: S/.{descuento:F2} soles.");
Console.WriteLine($"Total a pagar es de: S/.{totalPagar:F2} soles.");
Console.WriteLine($"Total de Caramelos regalasdos es: {regaloCaramelos} caramelos.");