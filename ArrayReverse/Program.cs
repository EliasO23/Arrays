// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("------|   UTILIZANDO LA FUNCION REVERSE   |------");
Console.WriteLine("-------------------------------------------------");

//Declaracion de arreglo
int[] enteros = { 4, 10, 45, -67, -7, 25, 89, 64 };

//Bucle para imprimir los arreglos
Console.WriteLine("\nLos números almacenados en la lista son: ");
Console.WriteLine("Posición | Num. Almacenado");
for (int i = 0; i < enteros.Length; i++)
{
    Console.WriteLine($" {i}- {enteros[i]}");
}

//Funcion REVERSE para revertir los valores e imprimirlos en pantalla
System.Array.Reverse( enteros );
Console.WriteLine("\nLos números con la función REVERSE son: ");
foreach (int mostar in enteros)
{
    Console.WriteLine($" - {mostar}");
}

//Funcion SORT para ordenar los valores e imprimirlos en pantalla
System.Array.Sort(enteros);
Console.WriteLine("\nLos números con la función SORT son: ");
foreach (int mostar in enteros)
{
    Console.WriteLine($" - {mostar}");
}
