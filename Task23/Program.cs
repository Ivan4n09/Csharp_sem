// Задача XXIII
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableAllCubes(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 4} {index*index*index, 5}"); // доп цифры в фигурных скобках делают отступ!
        index ++;
    }
}

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

TableAllCubes(number);

