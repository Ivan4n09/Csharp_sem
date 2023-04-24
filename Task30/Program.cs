// Задача XXX
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке

// [0,1,0,0,1,1,0,0]

int[] array = new int[8]; // обязательно скобки для массива
// int[] array = new int[8] {1,2,3,4,5,6,7,8};// - примеры ручного ввода массива
// int[] arr = {4,6,7,8};
// array[0] = 34; // присвоение
// int size = array.Length; // длина

Console.WriteLine("Введите длину массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lengthArray);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int [size];
    var random = new Random(); // оптимизация для очистки памяти (чтобы не в цикле все время создавался new random)
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(2); // или random.Next(0, 2) - 0 включен, 2 исключен
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}