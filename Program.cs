using System;

class Program
{
    static void Main()
    {
        // Definimos un arreglo de números
        int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.WriteLine("Ingrese el número que desea buscar:");
        int elementoBuscado = int.Parse(Console.ReadLine());

        // Variable para indicar si se encontró el elemento
        bool encontrado = false;

        // Bucle for para buscar el elemento en el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == elementoBuscado)
            {
                encontrado = true; // Se encontró el elemento
                break; // Salir del bucle
            }
        }

        // Mostrar el resultado
        if (encontrado)
        {
            Console.WriteLine($"El número {elementoBuscado} fue encontrado en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El número {elementoBuscado} no fue encontrado en el arreglo.");
        }

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}