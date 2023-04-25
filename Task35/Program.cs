// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10, 99]
// [1,2,11] -> 1
// [1,2,11,12] -> 2
// [1,2] -> 0

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
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, "); // тут есть пробел
        else Console.Write($"{arr[i]}"); // а тут нету пробела и запятой
    }
}

int FindCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99)
        count ++;
    }
    return count;
}

int[] array = CreateArrayRndInt(123, 0, 999);


Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Количество чисел от 10 до 99 - {FindCount(array)}");