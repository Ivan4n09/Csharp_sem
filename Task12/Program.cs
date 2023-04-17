// XII. Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли первое число кратным второму. 
// Если первое число не кратно второму, то программа
// выводит остаток от деления.

//  34, 5 -> не кратно, остаток 4
//  16, 4 -> кратно

Console.WriteLine("Введите пeрвое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Remainder(numberA, numberB);

// if (result > 0)
// Console.WriteLine($"Числа не кратные, остаток {result}");
// else
// Console.WriteLine($"Числа кратные, остаток {result}");

string res = result == 0 ? "кратно" : $"не кратно, остаток {result}"; // string, а не int, потому что в нем буквы

Console.Write(res);

int Remainder (int numA, int numB) // примечание себе: запомнить, как это работает
{
    return numA%numB;
}

// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// int remainder = numberA % numberB;

// if (remainder == 0)
// {
//     Console.WriteLine($"Числа кратные, остаток: {remainder}");
// }
// else
// {
//     Console.WriteLine($"Числа нечетные, остаток: {remainder}");
// }