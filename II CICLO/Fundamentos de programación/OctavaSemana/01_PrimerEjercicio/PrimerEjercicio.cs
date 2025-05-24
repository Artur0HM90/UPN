// See https://aka.ms/new-console-template for more information
/*
int resultado;
Saludo("arturo", "miguel");

static void Saludo(string nombre, string apellido)
{

}
static int Suma(int numero1, int numero2)
{
    return numero1 + numero2;
}

resultado = Suma(4, 5);
Console.WriteLine($"La Suma es: {resultado}");
*/

//FUNCIONES DE TIPO VOID 
string nombre, direccion;
Console.Write("Ingresa su nombre: ");
nombre = Console.ReadLine();

static void Saludar()
{
    Console.WriteLine("Estamos a la mitad del Ciclo 2024 - 2");
}

Saludar();

static void Despedir(string nombre)
{
    Console.WriteLine($"{nombre}, El Ciclo finaliza en diciemrbe. Hasta luego.");
}
Despedir(nombre);


//FUNCIONES CON VALOR DE RETORNO

static string texto()
{
    return "Calle 4 S/N Yungay";
}

direccion = texto();
Console.WriteLine($"La direccion es : {direccion}");


