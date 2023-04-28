// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int AmountEvenNumbersCheck(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(5, 100, 999);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Количество четных чисел - {AmountEvenNumbersCheck(array)}");