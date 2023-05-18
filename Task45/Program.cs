// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементарного копирования.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] CreateArrayCopy(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] arrayA = CreateArrayRndInt(6, -9, 9);
PrintArray(arrayA);

Console.WriteLine();

int[] arrayB = CreateArrayCopy(arrayA);

arrayB[5] = 999; // демонстрация

PrintArray(arrayB);

Console.WriteLine();

// короткое решение

int[] arrayC = new int[arrayA.Length];

Array.Copy(arrayA, arrayC, arrayA.Length);

arrayC[4] = 111; // демонстрация

Console.WriteLine();

PrintArray(arrayC);