// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string clave = "1234", password;
int intetos = 0;

do
{
    Console.Write("Ingrese contaseña: ");
    password = Console.ReadLine();
    if (password != clave)
    {
        Console.WriteLine("Error");
        intetos++;
    }
    else
    {
        break;
    }
} while (intetos < 3);
Console.WriteLine("Tu contraseña es correcta. Bienvenido.");




/*  SEGUNDA FORMA 
//Crear un algoritmo que permita 3 intentos para ingresar a un sistema de información.

string clave = "1234", password;
int intentos=3;

do
{
    Console.WriteLine("Ingrese su contraseña");
    password = Console.ReadLine();
    if (password == clave)
    {
        Console.WriteLine("Acceso autorizado, bienvenido al sistema");
    }
    intentos--;
    if(intentos == 0)
    {
        Console.WriteLine("Intentos agotados");
    }
} while ((intentos >0 && intentos <= 3) && password != clave);
Console.ReadKey();
*/