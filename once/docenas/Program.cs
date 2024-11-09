Console.Write("Ingrese su nombre: ");

string nom = Console.ReadLine();//el valor es un texto: William Valdibia Díaz

//Internamente se almacena como una colección de objetos Char (solo lectura)



//Funciones de cadenas String

Console.Write("Ingrese la palabra a buscar: ");

string palabra = Console.ReadLine();

Console.WriteLine("La cantidad de caracteres es: " + nom.Length);//propiedad o función: longitud

Console.WriteLine("La frase o palabra esta dentro " + nom.Contains(palabra));//propiedad: Contiene

Console.WriteLine("Reemplazamos por " + nom.Replace('b', 'v'));//propiedad o función: Reemplazar

Console.WriteLine("Remover caracteres " + nom.Remove(2));

Console.WriteLine("Extraer parte de la cadena: " + nom.Substring(1, 3));