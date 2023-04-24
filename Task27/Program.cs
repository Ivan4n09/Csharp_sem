// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number%10;
        number = number / 10;
    }
    return result;
}

int number = Prompt ("Введите число: ");

Console.WriteLine($"Сумма всех цифр в числе {number} = {SumAllDigits(number)}");