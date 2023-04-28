// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNumbersUnevenIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if( i % 2 == 1) // NB
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(5, 0, 10);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Cумма элементов, стоящих на нечётных позициях - {SumNumbersUnevenIndex(array)}");