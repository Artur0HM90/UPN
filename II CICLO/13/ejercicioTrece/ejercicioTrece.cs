using System;

class Program
{
    static void Main()
    {
        // Definición de los arreglos para almacenar los productos
        int[] codigo = new int[5];
        string[] producto = new string[5];
        decimal[] precio = new decimal[5];

        // Ingreso de datos de los productos
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese los datos para el producto {i + 1}");

            Console.Write("Código: ");
            codigo[i] = int.Parse(Console.ReadLine());

            Console.Write("Producto: ");
            producto[i] = Console.ReadLine();

            Console.Write("Precio: ");
            precio[i] = decimal.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        // Menú de opciones
        int opcion;
        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Listar productos");
            Console.WriteLine("2. Buscar producto por código");
            Console.WriteLine("3. Buscar producto por nombre");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nLista de Productos:");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Código: {codigo[i]}, Producto: {producto[i]}, Precio: {precio[i]:C}");
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Ingrese el código del producto a buscar: ");
                    int codigoBuscar = int.Parse(Console.ReadLine());
                    bool encontrado = false;

                    for (int i = 0; i < 5; i++)
                    {
                        if (codigo[i] == codigoBuscar)
                        {
                            Console.WriteLine($"Producto encontrado: Código: {codigo[i]}, Producto: {producto[i]}, Precio: {precio[i]:C}");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");
                    Console.WriteLine();
                    break;

                case 3:
                    // Buscar por nombre
                    Console.Write("Ingrese el nombre del producto a buscar: ");
                    string nombreBuscar = Console.ReadLine().ToLower();
                    encontrado = false;

                    for (int i = 0; i < 5; i++)
                    {
                        if (producto[i].ToLower() == nombreBuscar)
                        {
                            Console.WriteLine($"Producto encontrado: Código: {codigo[i]}, Producto: {producto[i]}, Precio: {precio[i]:C}");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                    break;
            }
        } while (opcion != 4);
    }
}