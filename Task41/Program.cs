// Задача 41: Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Введите {i+1}-й элемент");
//     }
//     return array;
// }

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

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int arrayLength = Prompt("Введите количество элементов >");
int arrayMin = Prompt("Введите минимальный элемент массива >");
int arrayMax = Prompt("Введите максимальный элемент массива >");
int [] array;
array = CreateArrayRndInt(arrayLength, arrayMin, arrayMax);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");