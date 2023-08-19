// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------------------------------------------");
Console.WriteLine("-------|   UTILIZANDO LA FUNCION SORT   |-------");
Console.WriteLine("------------------------------------------------");

//Declaracion de arreglos
string[] palabras = new string[10] {"Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

//Bucle para imprimir los arreglos
Console.WriteLine("\nLas palabras almacenadas en la lista son: ");
for (int i = 0; i < palabras.Length; i++)
{
    Console.WriteLine($" {i} - {palabras[i]}");
}

//Funcion SORT para ordenar los valores
System.Array.Sort(palabras);

//Bucle para volver a imprimir los valores ordenados
Console.WriteLine("\nLas palabras en orden alfabetico son: ");
foreach (string mostar in palabras)
{
    Console.WriteLine($" - {mostar}");
}