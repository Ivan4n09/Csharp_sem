// Задача XXVI
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе - {CountDigits(number)}");

int CountDigits(int num)
{
    int count = 0;
    while (num!=0) // != не равно
    {
        num /= 10;
        count++;
    }
    return count;
}