// Задача 32: Напишите программу замены элементов массива:
// положительные элементы заменить на отрицательные и наоборот
// [-2,1] -> [2,-1]

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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, "); // тут есть пробел
        else Console.Write($"{arr[i]}"); // а тут нету пробела и запятой
    }
}

int[] array = CreateArrayRndInt(5, -9, 9);


Console.Write("[");
PrintArray(array);
Console.WriteLine("] -> ");

InverseArray(array);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
