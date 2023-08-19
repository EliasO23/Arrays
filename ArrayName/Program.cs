// See https://aka.ms/new-console-template for more information


Console.WriteLine("------------------------------------------------");
Console.WriteLine("-------|  UTILIZANDO ARRAYS(ARREGLOS)   |-------");
Console.WriteLine("------------------------------------------------");

//Inicializacion del Array con tamaño y datos definidos
string[] name = new string[4] {"Elias", "Antonio", "Oliva", "Calderón"};

//Muestra los valores almacenados en el arreglo
Console.WriteLine("\nLos valores almacenados en el Array son: ");
foreach (string nostrar in name){
    Console.WriteLine($"- {nostrar}");
}

//Almacena el tamaño del Array
int TamañoArray = name.Length;

//Imprime el tamaño del Array y las posiciones en las que se encuentra cada valor
Console.WriteLine($"\nEl tamaño del Array es: {TamañoArray}");
for (int i = 0; i < name.Length; i++){
    Console.WriteLine($"- En la posicion {i} se encuentra: {name[i]}");
}

