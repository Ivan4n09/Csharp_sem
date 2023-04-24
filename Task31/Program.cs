// Задача 31: Задайте массив из 12 элементов, заполенный
// случайными числами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных элементов массива. (2 + 2 = 4) и (-2 + -3 = -5)

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

int SumPosElements (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegElements (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);

// PrintArray(array);
// Console.Write(" -> ["); // то же самое, что на строке 31, но со стрелкой

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine();

int sumPosElements = SumPosElements(array);
int sumNegElements = SumNegElements(array);

Console.WriteLine($"Сумма положительных элементов - {sumPosElements}");
Console.WriteLine($"Сумма отрицательных элементов - {sumNegElements}");