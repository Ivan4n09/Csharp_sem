// Задача 39:
// Напишите программу, которая перевернет одномерный массив
// [1 2 3] -> [3 2 1]

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

// Array.Reverse(array); - встроенный

void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i]; // i создает движение
        arr[arr.Length - 1 - i] = temp;
    }    
}

int[] array = CreateArrayRndInt(6, 1, 99);
PrintArray(array);

Console.WriteLine();

ReverseArray(array);
PrintArray(array);

Console.WriteLine();

Array.Reverse(array); // встроенный
PrintArray(array);