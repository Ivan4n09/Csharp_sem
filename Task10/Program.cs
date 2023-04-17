// Задача X: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string input)
{
    Console.Write(input);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число - ");
if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
System.Console.WriteLine($"Введенное число - {number}");
int secondDigit = number / 10 % 10;

System.Console.WriteLine($"Вторая цифра - {secondDigit}");