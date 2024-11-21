
        Console.WriteLine("Ingrese el nombre completo (nombres y apellidos):");
        string nombreCompleto = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(nombreCompleto))
        {
            Console.WriteLine("El nombre ingresado no puede estar vacío.");
            return;
        }


        string[] palabras = nombreCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (palabras.Length < 2)
        {
            Console.WriteLine("Por favor, ingrese al menos un nombre y un apellido.");
            return;
        }


        string nombres = string.Join(" ", palabras[0..^2]); 
        string apellidos = string.Join(" ", palabras[^2..]); 


        nombres = FormatearTexto(nombres);
        apellidos = FormatearTexto(apellidos);


        Console.WriteLine($"{apellidos}, {nombres}");
    


    static string FormatearTexto(string texto)
    {
        string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i][1..].ToLower();
        }
        return string.Join(" ", palabras);
    }
