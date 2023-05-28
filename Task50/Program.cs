// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


// int[,] CreateMatrix (int rows, int columns) // из Task48
// {
//     int[,] matrix = new int[rows,columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i+j;
//         }
//     }
//     return matrix;
// }

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

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
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
        Console.WriteLine(" |");
    }
}

void PromptMatrixPosition (int[,] matrix)
{
    int coordRow = Prompt("Введите строку > ");
    int coordColumn = Prompt("Введите столбец > ");

    if (coordRow < 0 || coordColumn < 0 || coordRow >= matrix.GetLength(0) || coordColumn >= matrix.GetLength(1))
    {
        Console.WriteLine("Неверные координаты");
    }
    else
    {
        Console.WriteLine($"Значение элемента на позиции [{coordRow}, {coordColumn}] = {matrix[coordRow, coordColumn]}");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);

// int coordRow = Prompt("Введите строку >");
// int coordColumn = Prompt("Введите строку >");

// if (coordRow < 0 || coordColumn < 0 || coordRow >= array2d.GetLength(0) || coordColumn >= array2d.GetLength(1))
// Console.WriteLine("Неверные координаты");
// else
// Console.WriteLine($"Содержание > {array2d[coordRow,coordColumn]}");
// Console.WriteLine();

PrintMatrix(array2d);

PromptMatrixPosition(array2d);