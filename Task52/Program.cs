// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("  |");
    }
}

void ArithmeticalMeanAllElementsEachColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++) // iteration over COLUMNS - GetLength(1)
    {
        int columnSum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++) // iteration over ROWS - GetLength(0)
        {
            columnSum += matrix[j, i]; // add element to column sum
        }
        double mean = (double)columnSum / matrix.GetLength(0); // calculate average
        Console.WriteLine($"Среднее арифметическое столбца {i}: {mean, 10:F3}");
    }
}

int[,] array2d = CreateMatrixRndInt(3 , 4, 0, 9);
PrintMatrix(array2d);

ArithmeticalMeanAllElementsEachColumn(array2d);