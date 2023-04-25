// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; [1,2,3] -> нет
// 3; [1,2,3] -> да

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

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

bool NumberCheck(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(5, 1, 5);

int number = Prompt("Ваше число: ");

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

// if (NumberCheck(number, array))
// Console.Write($"Число {number} присутствует в массиве");
// else
// Console.Write($"Число {number} отсутствует в массиве");

bool numberCheck = NumberCheck(number, array);
Console.WriteLine();
Console.WriteLine(numberCheck ? $"Число {number} присутствует в массиве" : $"Число {number} отсутствует в массиве");