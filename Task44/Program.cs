// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите целое положительное число");
// int inputNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число");
int inputNumber;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 0)
    {
        break;
    }
    Console.WriteLine("Неверный ввод. Введите целое положительное число.");
}

int[] fibonacci = Fibonacci(inputNumber);
PrintArray(fibonacci);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

// int[] Fibonacci(int size)
// {
//     int[] array = new int[size];
//     // array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }

int[] Fibonacci(int size)
{
    if (size <= 0)
    {
        throw new ArgumentException("Size must be a positive integer greater than zero", nameof(size));
    }

    int[] array = new int[size];
    array[0] = 0;
    if (size > 1)
    {
        array[1] = 1;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = array[i-1] + array[i-2];
        }
    }
    return array;
}