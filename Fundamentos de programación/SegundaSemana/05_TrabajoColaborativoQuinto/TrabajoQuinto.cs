// See https://aka.ms/new-console-template for more information
/*
5. Desarrollar el algoritmo para determinar el área de un rombo. A = (D * d )/2
Donde D = Lado mayor
Donde d = Lado menor
*/

int ladoMayor, ladoMenor, area;

Console.Write("Ingresa el lado mayor: ");
ladoMayor = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el lado mayor: ");
ladoMenor = Convert.ToInt32(Console.ReadLine());

area = ((ladoMayor * ladoMenor) / 2);


Console.WriteLine($"El area del rombo es: {area}.");
