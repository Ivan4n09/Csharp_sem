﻿// Задача 48: Задайте двумерный массив размером m на n
// каждый элемент находится по формуле Amn = m + n
// Вывести полученный массив на экран

// m = 3, n = 4

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrix (int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// строки - нулевое измерение массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // первое измерение
        {
            matrix[i, j] = i+j; // - условие
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
            Console.Write($"{matrix[i,j], 5} "); // 5 - длина строки вывода
        }
        Console.WriteLine(" |");
    }
}

int[,] array2d = CreateMatrix(3, 4);
PrintMatrix(array2d);