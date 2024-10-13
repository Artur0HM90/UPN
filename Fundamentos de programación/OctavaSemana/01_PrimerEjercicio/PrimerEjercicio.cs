// See https://aka.ms/new-console-template for more information

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