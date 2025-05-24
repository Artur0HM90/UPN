namespace ArreglosEjercicio
{
    class Program
    {
        static int[] arregloA = new int[5];
        static int[] arregloB = new int[5];
        static Random random = new Random();

        static void Main(string[] args)
        {
            LlenarArreglosConAleatorios();
            MostrarMenu();
        }

        static void LlenarArreglosConAleatorios()
        {
            for (int i = 0; i < 5; i++)
            {
                arregloA[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100
                arregloB[i] = random.Next(1, 101);
            }
            Console.WriteLine("Arreglos A y B llenados con números aleatorios.");
        }

        static void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Insertar elemento en el arreglo");
                Console.WriteLine("2. Eliminar elemento del arreglo");
                Console.WriteLine("3. Mostrar arreglo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        InsertarElemento();
                        break;
                    case 2:
                        EliminarElemento();
                        break;
                    case 3:
                        MostrarArreglo();
                        break;
                    case 4:
                        continuar = false;
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void InsertarElemento()
        {
            Console.Write("Ingrese el nombre del arreglo (A o B): ");
            string nombreArreglo = Console.ReadLine().ToUpper();
            int[] arregloSeleccionado = nombreArreglo == "A" ? arregloA : arregloB;

            Console.Write("Ingrese la posición (0-4): ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion < 0 || posicion >= arregloSeleccionado.Length)
            {
                Console.WriteLine("Posición no válida.");
                return;
            }

            Console.Write("Ingrese el valor a insertar: ");
            int valor = int.Parse(Console.ReadLine());

            if (arregloSeleccionado[posicion] == 0)
            {
                arregloSeleccionado[posicion] = valor;
                Console.WriteLine($"Valor {valor} insertado en el arreglo {nombreArreglo} en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine("La posición ya está ocupada. No se puede insertar.");
            }
        }

        static void EliminarElemento()
        {
            Console.Write("Ingrese el nombre del arreglo (A o B): ");
            string nombreArreglo = Console.ReadLine().ToUpper();
            int[] arregloSeleccionado = nombreArreglo == "A" ? arregloA : arregloB;

            Console.Write("Ingrese la posición (0-4): ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion < 0 || posicion >= arregloSeleccionado.Length)
            {
                Console.WriteLine("Posición no válida.");
                return;
            }

            if (arregloSeleccionado[posicion] != 0)
            {
                Console.WriteLine($"Elemento {arregloSeleccionado[posicion]} eliminado del arreglo {nombreArreglo} en la posición {posicion}.");
                arregloSeleccionado[posicion] = 0; // Asigna 0 para indicar que está vacío
            }
            else
            {
                Console.WriteLine("La posición ya está vacía. No se puede eliminar.");
            }
        }

        static void MostrarArreglo()
        {
            Console.Write("Ingrese el nombre del arreglo a mostrar (A o B): ");
            string nombreArreglo = Console.ReadLine().ToUpper();
            int[] arregloSeleccionado = nombreArreglo == "A" ? arregloA : arregloB;

            Console.WriteLine($"Contenido del arreglo {nombreArreglo}:");
            for (int i = 0; i < arregloSeleccionado.Length; i++)
            {
                Console.Write($"{arregloSeleccionado[i]} ");
            }
            Console.WriteLine();
        }
    }
}