using System;

class Program
{
    static void Main()
    {
        // Declaración de las matrices de tamaño 2x2
        int[,] matriz1 = new int[2, 2];
        int[,] matriz2 = new int[2, 2];
        int[,] resultado = new int[2, 2];

        // Solicitar al usuario que ingrese los valores para la primera matriz
        Console.WriteLine("Ingrese los valores para la primera matriz: ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Elemento [{0}, {1}]: ", i, j);
                matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Solicitar al usuario que ingrese los valores para la segunda matriz
        Console.WriteLine("Ingrese los valores para la segunda matriz: ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Elemento [{0}, {1}]: ", i, j);
                matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calcular la suma de las matrices
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Imprimir el resultado de la suma de las matrices
        Console.WriteLine("La suma de las matrices es: ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}