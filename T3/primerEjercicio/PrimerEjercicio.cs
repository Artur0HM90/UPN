int opcion, posicion, valor;

int[] A = new int[5];
int[] B = new int[5];
Random random = new Random();

// Llenar los arreglos A y B con números aleatorios entre 1 y 100
for (int i = 0; i < 5; i++)
{
    A[i] = random.Next(1, 101);
    B[i] = random.Next(1, 101);
}

void InsertarElemento(ref int[] arreglo, int posicion, int valor)
{
    if (posicion < 0 || posicion >= arreglo.Length)
    {
        Console.WriteLine("La posición esta fuera de rango.");
        return;
    }

    if (arreglo[posicion] != 0)
    {
        Console.WriteLine("La posición ya está ocupada. Intente en otra posición.");
    }
    else
    {
        arreglo[posicion] = valor;
        Console.WriteLine($"Valor {valor} insertado en posición {posicion} del arreglo.");
    }
}

void EliminarElemento(ref int[] arreglo, int posicion)
{
    if (posicion < 0 || posicion >= arreglo.Length)
    {
        Console.WriteLine("Posición fuera de rango.");
        return;
    }

    if (arreglo[posicion] == 0)
    {
        Console.WriteLine("La posición ya está vacía.");
    }
    else
    {
        arreglo[posicion] = 0;
        Console.WriteLine($"Elemento en posición {posicion} eliminado.");
    }
}


void MostrarArreglo(int[] arreglo, string nombre)
{
    Console.WriteLine($"\nArreglo {nombre}:");
    foreach (int num in arreglo)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

// Mostrar los arreglos A y B iniciales

MostrarArreglo(A, "A");
MostrarArreglo(B, "B");

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("[1] Insertar elemento");
    Console.WriteLine("[2] Eliminar elemento");
    Console.WriteLine("[3] Mostrar arreglos");
    Console.WriteLine("[4] Salir");
    Console.Write("Elige entre 1 - 4: ");
    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del arreglo (A o B): ");
            string nombreArreglo = Console.ReadLine().ToUpper();
            int[] arregloSeleccionado = (nombreArreglo == "A") ? A : (nombreArreglo == "B") ? B : null;

            if (arregloSeleccionado != null)
            {
                Console.Write("Ingrese la posición (0 a 4): ");
                posicion = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el valor a insertar: ");
                valor = Convert.ToInt32(Console.ReadLine());
                InsertarElemento(ref arregloSeleccionado, posicion, valor);
            }
            else
            {
                Console.WriteLine("Arreglo no válido.");
            }
            break;

        case 2:
            Console.Write("Ingrese el nombre del arreglo (A o B): ");
            nombreArreglo = Console.ReadLine().ToUpper();
            arregloSeleccionado = (nombreArreglo == "A") ? A : (nombreArreglo == "B") ? B : null;

            if (arregloSeleccionado != null)
            {
                Console.Write("Ingrese la posición (0 a 4): ");
                posicion = Convert.ToInt32(Console.ReadLine());
                EliminarElemento(ref arregloSeleccionado, posicion);
            }
            else
            {
                Console.WriteLine("Arreglo no válido.");
            }
            break;

        case 3:
            MostrarArreglo(A, "A");
            MostrarArreglo(B, "B");
            break;

        case 4:
            continuar = false;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}