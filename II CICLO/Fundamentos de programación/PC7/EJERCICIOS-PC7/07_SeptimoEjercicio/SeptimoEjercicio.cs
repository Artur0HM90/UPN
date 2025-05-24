// See https://aka.ms/new-console-template for more information
/*
3.	Una empresa de transportes brinda servicios en dos rutas (Lima-Huánuco y Lima-Huancayo) en tres calidades de servicio a los precios por boleto dados en la siguiente tabla:

                Precio del boleto
Calidad	        Lima-Huánuco	Lima-Huancayo
    A	        S/. 45	            S/. 38
    B	        S/. 35	            S/. 33
    C	        S/.30	            S/. 28

Como oferta, la empresa efectúa 5% de descuento sobre el importe de la compra únicamente para compras de boletos de calidad A, independientemente de la ruta elegida, siempre y cuando la cantidad de boletos adquiridos sea más de 4.

Dada la ruta elegida, la calidad del servicio y la cantidad de boletos adquiridos, diseñe un programa que determine el importe de la compra, el importe del descuento y el importe a pagar.

*/

int calidadDelBoleto, elegirRuta, cantidadBoletos;
double descuento = 0.05, precioDeBoletos = 0, descuentoDelCompras = 0, totalPagar = 0;
int precioLimaHuanuco_A = 45, precioLimaHuancayo_A = 38, precioLimaHuanuco_B = 35, precioLimaHuancayo_B = 33, precioLimaHuanuco_C = 30, precioLimaHuancayo_C = 28;


do
{
    Console.WriteLine("Que calidad de boleto vas comprar: ");
    Console.WriteLine("[1] Calidad de boleto A");
    Console.WriteLine("[2] Calidad de boleto B");
    Console.WriteLine("[3] Calidad de boleto C");
    Console.Write("Elige entre 1 - 3: ");
    calidadDelBoleto = Convert.ToInt32(Console.ReadLine());
} while (calidadDelBoleto <= 0 || calidadDelBoleto >= 4);

do
{
    Console.WriteLine("Que ruta vas elegir: ");
    Console.WriteLine("[1] Lima-Huánuco: ");
    Console.WriteLine("[2] Lima-Huancayo: ");
    Console.Write("Elige entre 1 - 2: ");
    elegirRuta = Convert.ToInt32(Console.ReadLine());
} while (elegirRuta <= 0 || elegirRuta >= 3);

Console.Write("Cuantos boletos vas a comprar: ");
cantidadBoletos = Convert.ToInt32(Console.ReadLine());

switch (calidadDelBoleto)
{
    case 1:
        switch (elegirRuta)
        {
            case 1:
                if (cantidadBoletos <= 4)
                {
                    precioDeBoletos = cantidadBoletos * precioLimaHuanuco_A;
                }
                else
                {
                    precioDeBoletos = cantidadBoletos * precioLimaHuanuco_A;
                    descuentoDelCompras = precioDeBoletos * descuento;
                    totalPagar = precioDeBoletos - descuento;
                }
                break;
            case 2:
                if (cantidadBoletos <= 4)
                {
                    precioDeBoletos = cantidadBoletos * precioLimaHuancayo_A;
                }
                else
                {
                    precioDeBoletos = cantidadBoletos * precioLimaHuancayo_A;
                    descuentoDelCompras = precioDeBoletos * descuento;
                    totalPagar = precioDeBoletos - descuento;
                }
                break;
        }
        break;
    case 2:
        switch (elegirRuta)
        {
            case 1:
                precioDeBoletos = cantidadBoletos * precioLimaHuanuco_B;
                break;
            case 2:
                precioDeBoletos = cantidadBoletos * precioLimaHuancayo_B;
                break;
        }
        break;
    case 3:
        switch (elegirRuta)
        {
            case 1:
                precioDeBoletos = cantidadBoletos * precioLimaHuanuco_C;
                break;
            case 2:
                precioDeBoletos = cantidadBoletos * precioLimaHuancayo_C;
                break;
        }
        break;
}
if (descuentoDelCompras > 0)
{
    Console.WriteLine($"Compraste {calidadDelBoleto} boletos.");
    Console.WriteLine($"El importe de la compra es: S/.{precioDeBoletos} soles.");
    Console.WriteLine($"Tienes un descuento de: S/.{descuentoDelCompras} soles.");
    Console.WriteLine($"Total a pagar es de: S/.{totalPagar} soles.");
}

Console.WriteLine($"Total a pagar es de: S/.{precioDeBoletos} soles.");