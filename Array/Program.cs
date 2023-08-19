// See https://aka.ms/new-console-template for more information
using System.Drawing;
Console.WriteLine("------------------------------------------------");
Console.WriteLine("-------|  UTILIZANDO ARRAYS(ARREGLOS)   |-------");
Console.WriteLine("------------------------------------------------");

//Inicializacion del Array sin tamaño
float[] Num;

bool comprobar = true;
while (comprobar == true)
{
    //Ingreso del tamaño del Array por el usuario
    Console.Write("\n- Ingrese el tamaño del arreglo que desea: ");
    int tamaño = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    //Se muestra cuando el usuario ingresa un numero menor a 5
    if (tamaño < 5)
    {
        Console.WriteLine("El tamaño del arreglo debe ser mayor o igual a 5");
    }

    //Se ejecuta esta parte del codigo cuando se a ingresa un numero mayor o igual a 5
    else
    {
        //Ingreso del tamaño del Array indicado por el usuario
        Num = new float[tamaño];

        //Ingreso de los valores desde teclado
        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine($"Ingrese el valor de la posicion {i}: ");
            Num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n¿Desea imprimir su lista de valores?");
        Console.WriteLine("  1. Si");
        Console.WriteLine("  2. No");
        int desi = Convert.ToInt32(Console.ReadLine());
        switch (desi)
        {
            case 1:
                //Imprime los valores del Array
                Console.WriteLine($"\nSus valores son: ");
                foreach (var valor in Num)
                {
                    Console.WriteLine($" - {valor}");
                }
                break;

            case 2:
                break;

            default:
                Console.WriteLine("Opcion Invalida"); ;
                break;


        }

        Console.WriteLine("\n¿Desea ingresar otro arreglo?");
        Console.WriteLine("  1. Si");
        Console.WriteLine("  2. No");
        int desi1 = Convert.ToInt32(Console.ReadLine());
        switch (desi1)
        {
            case 1:
                //Vuelve a comenzar el bucle
                continue;

            case 2:
                //Despedida al usuario
                Console.WriteLine("\nGracias por utilizar este programa");
                Console.WriteLine(" - Vuelva pronto\n");
                comprobar = false;
                break;

            default:
                Console.WriteLine("Opcion Invalida"); ;
                break;

        }

    }

}
