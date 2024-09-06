// See https://aka.ms/new-console-template for more information
/*
1. Una dulcería vende chocolates a los precios dados en la siguiente tabla:

Tipo de chocolate               Precio unitario
    Primor                          S/ 8.5
    Dulzura                         S/ 10    
    Tentación                       S/ 7
    Explosión                       S/ 12.5

Como oferta, la tienda aplica un porcentaje de descuento sobre el importe de la compra, basándose en la cantidad de chocolates adquiridos, de acuerdo con la siquiente tabla:

Cantidad de chocolates          Descuento
        < 5                         4%
    >= 5 y < 10                     6.5%
    >= 10 y < 15                    9%
    >= 15                           11.5%              

Adicionalmente, si el importe a pagar es no menor de S/. 250, la tienda obsequia 3 caramelos por cada chocolate;
en caso contrario, obsequia 2 caramelos por cada chocolate.

Dado el tipo de chocolate y la cantidad de unidades adquiridas, diseñe un programa que determine el importe de la compra, el importe del descuento, el importe a pagar y la cantidad de caramelos de obsequio.
*/

using System.Net.Quic;

int eligeTipoDeChocolate, cantidadDechocolates;
int carameloObsequioMayor = 3, carameloObsequioMenor = 2;
double precioPrimor = 8.5, precioDulzura = 10, precioTentacion = 7, precioExplosion = 12.5; // precios
double primerDescuento = 0.04, segundoDescuento = 0.065, tercerDescuento = 0.09, cuartoDescuento = 0.115; // descuentos
double precioPorChocolates = 0, descuento = 0, total = 0;
int totalDeCaramelos = 0;

do
{
    Console.WriteLine("============================");
    Console.WriteLine("ELIGE EL TIPO DE CHOCOLATE: ");
    Console.WriteLine("============================");
    Console.WriteLine("[1] Primor.");
    Console.WriteLine("[2] Dulzura.");
    Console.WriteLine("[3] Tentación.");
    Console.WriteLine("[4] Explosión.");
    Console.Write("Elige entre 1 - 4: ");
    eligeTipoDeChocolate = Convert.ToInt32(Console.ReadLine());
} while (eligeTipoDeChocolate < 1 || eligeTipoDeChocolate > 4);

do
{
    Console.Write("Cuatos chocolates vas a comprar: ");
    cantidadDechocolates = Convert.ToInt32(Console.ReadLine());
} while (cantidadDechocolates <= 0);

switch (eligeTipoDeChocolate)
{
    case 1:
        Console.WriteLine("==================");
        Console.WriteLine("CHOCOLATE PRIMOR");
        Console.WriteLine("==================");
        if (cantidadDechocolates < 5)
        {
            precioPorChocolates = cantidadDechocolates * precioPrimor;
            descuento = precioPorChocolates * primerDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 5 && cantidadDechocolates < 10)
        {
            precioPorChocolates = cantidadDechocolates * precioPrimor;
            descuento = precioPorChocolates * segundoDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 10 && cantidadDechocolates < 15)
        {
            precioPorChocolates = cantidadDechocolates * precioPrimor;
            descuento = precioPorChocolates * tercerDescuento;
            total = precioPorChocolates - descuento;
        }
        else
        {
            precioPorChocolates = cantidadDechocolates * precioPrimor;
            descuento = precioPorChocolates * cuartoDescuento;
            total = precioPorChocolates - descuento;
            if (total < 250)
            {
                totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
            }
            else
            {
                totalDeCaramelos = carameloObsequioMayor * cantidadDechocolates;
            }
        }
        break;

    case 2:
        Console.WriteLine("==================");
        Console.WriteLine("CHOCOLATE DULZURA");
        Console.WriteLine("==================");
        if (cantidadDechocolates < 5)
        {
            precioPorChocolates = cantidadDechocolates * precioDulzura;
            descuento = precioPorChocolates * primerDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 5 && cantidadDechocolates < 10)
        {
            precioPorChocolates = cantidadDechocolates * precioDulzura;
            descuento = precioPorChocolates * segundoDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 10 && cantidadDechocolates < 15)
        {
            precioPorChocolates = cantidadDechocolates * precioDulzura;
            descuento = precioPorChocolates * tercerDescuento;
            total = precioPorChocolates - descuento;
        }
        else
        {
            precioPorChocolates = cantidadDechocolates * precioDulzura;
            descuento = precioPorChocolates * cuartoDescuento;
            total = precioPorChocolates - descuento;
            if (total < 250)
            {
                totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
            }
            else
            {
                totalDeCaramelos = carameloObsequioMayor * cantidadDechocolates;
            }
        }
        break;

    case 3:
        Console.WriteLine("====================");
        Console.WriteLine("CHOCOLATE TENTACIÓN");
        Console.WriteLine("====================");
        if (cantidadDechocolates < 5)
        {
            precioPorChocolates = cantidadDechocolates * precioTentacion;
            descuento = precioPorChocolates * primerDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 5 && cantidadDechocolates < 10)
        {
            precioPorChocolates = cantidadDechocolates * precioTentacion;
            descuento = precioPorChocolates * segundoDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 10 && cantidadDechocolates < 15)
        {
            precioPorChocolates = cantidadDechocolates * precioTentacion;
            descuento = precioPorChocolates * tercerDescuento;
            total = precioPorChocolates - descuento;
        }
        else
        {
            precioPorChocolates = cantidadDechocolates * precioTentacion;
            descuento = precioPorChocolates * cuartoDescuento;
            total = precioPorChocolates - descuento;
            if (total < 250)
            {
                totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
            }
            else
            {
                totalDeCaramelos = carameloObsequioMayor * cantidadDechocolates;
            }
        }
        break;

    case 4:
        Console.WriteLine("====================");
        Console.WriteLine("CHOCOLATE EXPLOSIÓN");
        Console.WriteLine("====================");
        if (cantidadDechocolates < 5)
        {
            precioPorChocolates = cantidadDechocolates * precioExplosion;
            descuento = precioPorChocolates * primerDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 5 && cantidadDechocolates < 10)
        {
            precioPorChocolates = cantidadDechocolates * precioExplosion;
            descuento = precioPorChocolates * segundoDescuento;
            total = precioPorChocolates - descuento;
            totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
        }
        else if (cantidadDechocolates >= 10 && cantidadDechocolates < 15)
        {
            precioPorChocolates = cantidadDechocolates * precioExplosion;
            descuento = precioPorChocolates * tercerDescuento;
            total = precioPorChocolates - descuento;
        }
        else
        {
            precioPorChocolates = cantidadDechocolates * precioExplosion;
            descuento = precioPorChocolates * cuartoDescuento;
            total = precioPorChocolates - descuento;
            if (total < 250)
            {
                totalDeCaramelos = carameloObsequioMenor * cantidadDechocolates;
            }
            else
            {
                totalDeCaramelos = carameloObsequioMayor * cantidadDechocolates;
            }
        }
        break;
}
Console.WriteLine($"El precio por los chocolates es: S/{precioPorChocolates} soles.");
Console.WriteLine($"Tienes un descuento de: S/{descuento} soles.");
Console.WriteLine($"Total a pagar es de: S/{total} soles.");
Console.WriteLine($"Caramelos de obsequio total: {totalDeCaramelos} ");