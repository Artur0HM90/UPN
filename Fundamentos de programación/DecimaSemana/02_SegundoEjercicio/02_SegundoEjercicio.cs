// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Mundo UPN");



int a, b, tem;

Console.Write("Ingrese el primer numero: ");
a = Convert.ToInt32(Console.ReadLine()); // 15
Console.Write("Ingrese eñ segundo numero");
b = Convert.ToInt32(Console.ReadLine()); // 5

if (a == b)
{
    Console.WriteLine("Debe ingresar numeros diferentes");
}
else
{
    if (a > b)
    {
        tem = b; //5
        b = a; //15
        a = tem; //5
    }
    while (a <= b)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine(a); //6, 8, ...
        }
        a = a + 1;
    }
}

Console.ReadKey();
