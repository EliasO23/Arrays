// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("----|   UTILIZANDO LA FUNCION BINARYSEARCH   |----");
Console.WriteLine("--------------------------------------------------");

//Declaración de variables
string[] palabras = new string[10] { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

//Funcion SORT para ordenar los valores
System.Array.Sort(palabras);

//Bucle para imprimir los valores ordenados
Console.WriteLine("\nLas palabras almacenadas en la lista son: ");
foreach (string mostar in palabras)
{
    Console.WriteLine($" - {mostar}");
}

Console.WriteLine("\nBuscar las siguientes posiciones de las palabras: ");
Console.WriteLine(" - Sol");
Console.WriteLine(" - Dedo");
Console.WriteLine(" - Casa\n");

//Funcion BinarySearch para buscar las palabras
int posicion;
for (int i = 0; i < palabras.Length; i++)
{
    if (palabras[i] == "Sol")
    {
        posicion = System.Array.BinarySearch(palabras, $"{palabras[i]}");
        Console.WriteLine($"La palabra {palabras[i]} se encuentra en la posicion: {posicion}");
    }

    else if (palabras[i] == "Dedo")
    {
        posicion = System.Array.BinarySearch(palabras, $"{palabras[i]}");
        Console.WriteLine($"La palabra {palabras[i]} se encuentra en la posicion: {posicion}");
    }

    else if (palabras[i] == "Casa")
    {
        posicion = System.Array.BinarySearch(palabras, $"{palabras[i]}");
        Console.WriteLine($"La palabra {palabras[i]} se encuentra en la posicion: {posicion}");
    }


}

//Otra forma de realizar la busqueda de las palabras
//posicion = System.Array.BinarySearch(palabras, "Sol");
//Console.WriteLine($"La palabra Sol se encuentra en la posicion: {posicion}");
//posicion = System.Array.BinarySearch(palabras, "Dedo");
//Console.WriteLine($"La palabra Dedo se encuentra en la posicion: {posicion}");
//posicion = System.Array.BinarySearch(palabras, "Casa");
//Console.WriteLine($"La palabra Casa se encuentra en la posicion: {posicion}");

