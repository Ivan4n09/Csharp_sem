// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double [size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.NextDouble()*(max-min) + min; // RANGE = MAX-MIN!! тогда мы получим сгенерированный double массив в нужном диапазоне
//     }
//     return arr;
// }

double[] CreateArrayRndDoubleArrWithOneDecimalNumbers(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1); // уровень округления - 1
    }
    return arr;
}

void PrintArray(double[] arr) // тут double!
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if(i < arr.Length - 1) Console.Write($"{arr[i]} , "); // added spaces to not confuse decimals
        else Console.Write($"{arr[i]}");
    }
}

double DifferenceMinMaxArrayElements(double[] arr)
{
    double difference = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];      
    }
    difference = max - min;
    return difference;
}

double[] array = CreateArrayRndDoubleArrWithOneDecimalNumbers(5, 1, 10);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Difference between min and max elements - { Math.Round ( DifferenceMinMaxArrayElements (array), 1 ) }");