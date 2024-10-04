// See https://aka.ms/new-console-template for more information
/*
4.	Una web clasifica a sus usuarios basándose en la cantidad de mensajes publicados en los foros de acuerdo con la siguiente tabla:
Número de mensajes	            Clase de usuario
0 a 49	                        Desconocido
50 a 99	                        Humano
100 a 249	                    Diclonius Inicial
250 a 499	                    Diclonius Novato
500 a 999	                    Diclonius Experimentado
1000 a 1999	                    Diclonius Elite
2000 a 4999	                    Diclonius Definitivo
5000 a más	                    Diclonius Legendario

Dado el número de mensajes publicados por un usuario, diseñe un programa que determine la clasificación que le corresponde.

*/

int numeroDeMensajes;
string mensaje = " ";
Console.Write("Ingresa cuatos mensajes publicados: ");
numeroDeMensajes = Convert.ToInt32(Console.ReadLine());

if (numeroDeMensajes >= 0 && numeroDeMensajes <= 49)
{
    mensaje = "Desconocido";
}
else if (numeroDeMensajes >= 50 && numeroDeMensajes <= 99)
{
    mensaje = "Humano";
}
else if (numeroDeMensajes >= 100 && numeroDeMensajes <= 249)
{
    mensaje = "Diclonius Inicial";
}
else if (numeroDeMensajes >= 250 && numeroDeMensajes <= 499)
{
    mensaje = "Diclonius Novato";
}
else if (numeroDeMensajes >= 500 && numeroDeMensajes <= 999)
{
    mensaje = "Diclonius Experimentado";
}
else if (numeroDeMensajes >= 1000 && numeroDeMensajes <= 1999)
{
    mensaje = "Diclonius Elite";
}
else if (numeroDeMensajes >= 2000 && numeroDeMensajes <= 4999)
{
    mensaje = "HumDiclonius Definitivoano";
}
else
{
    mensaje = "Diclonius Legendario";
}
Console.Write($"La clasificación del mensaje es {mensaje}.");