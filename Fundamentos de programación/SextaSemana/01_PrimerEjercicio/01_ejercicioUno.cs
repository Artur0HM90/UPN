// See https://aka.ms/new-console-template for more information

float ingresePrimerNumero;
float ingreseSegundoNumero;
int opcion;
float resultado;

do
{
    Console.Write("CALCULADORA BÁSICA\n");
    Console.Write("[1] Suma\n");
    Console.Write("[2] Resta\n");
    Console.Write("[3] Multiplicaión\n");
    Console.Write("[4] División\n");
    Console.Write("Elige entre 1 - 4: ");
    opcion = Convert.ToInt32(Console.ReadLine());
} while (opcion < 0 || opcion > 4);


if (opcion == 1)
{
    Console.Write("=======\n");
    Console.Write(" SUMA\n");
    Console.Write("=======\n");
    Console.Write("Ingrese primer número: ");
    ingresePrimerNumero = Convert.ToSingle(Console.ReadLine());

    Console.Write("Ingrese segundo número: ");
    ingreseSegundoNumero = Convert.ToSingle(Console.ReadLine());
    resultado = ingresePrimerNumero + ingreseSegundoNumero;
}
else if (opcion == 2)
{
    Console.Write("========\n");
    Console.Write(" RESTA\n");
    Console.Write("========\n");
    Console.Write("Ingrese primer número: ");
    ingresePrimerNumero = Convert.ToSingle(Console.ReadLine());

    Console.Write("Ingrese segundo número: ");
    ingreseSegundoNumero = Convert.ToSingle(Console.ReadLine());
    resultado = ingresePrimerNumero - ingreseSegundoNumero;
}
else if (opcion == 3)
{
    Console.Write("===============\n");
    Console.Write("MULTIPLICACIÓN\n");
    Console.Write("===============\n");
    Console.Write("Ingrese primer número: ");
    ingresePrimerNumero = Convert.ToSingle(Console.ReadLine());

    Console.Write("Ingrese segundo número: ");
    ingreseSegundoNumero = Convert.ToSingle(Console.ReadLine());
    resultado = ingresePrimerNumero * ingreseSegundoNumero;
}
else
{
    Console.Write("===========\n");
    Console.Write(" DIVISIÓN\n");
    Console.Write("===========\n");
    Console.Write("Ingrese primer número: ");
    ingresePrimerNumero = Convert.ToSingle(Console.ReadLine());
    /*
        Console.Write("Ingrese primer número: ");
        ingreseSegundoNumero = Convert.ToSingle(Console.ReadLine());
        if (ingreseSegundoNumero == 0)
        {
            Console.Write("NO SE PUEDE DIVIDIR ENTRE CERO");
        }
        else
        {
            resultado = ingresePrimerNumero * ingreseSegundoNumero;
        }
    */
    do
    {
        Console.Write("Ingrese segundo número: ");
        ingreseSegundoNumero = Convert.ToSingle(Console.ReadLine());
        if (ingreseSegundoNumero == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre 0. Por favor, ingrese un número distinto de 0.");
        }
    } while (ingreseSegundoNumero == 0);
    resultado = ingresePrimerNumero / ingreseSegundoNumero;
}
Console.Write("===========\n");
Console.Write(" RESULTADO\n");
Console.Write("===========\n");
Console.WriteLine($"El resultado es:{resultado} ");
