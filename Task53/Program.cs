// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("  |");
    }
}

void SwapFirstLastRows(int[,] matrix)
{
    int[] firstRow = new int[matrix.GetLength(1)];
    int[] lastRow = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        firstRow[j] = matrix[0, j];
        lastRow[j] = matrix[matrix.GetLength(0) - 1, j];
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = lastRow[j];
        matrix[matrix.GetLength(0) - 1, j] = firstRow[j];
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2d);

Console.WriteLine();

SwapFirstLastRows(array2d);
PrintMatrix(array2d);