// XI. Напишите программу, которая 
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число - {number}");

int RemoveSecDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int twoDigitNumber = firstDigit * 10 + thirdDigit;
    return twoDigitNumber;
}

// int answer = RemoveSecDigit(number);
// Console.WriteLine($"Это число с убранной второй цифрой -> {answer}");

Console.WriteLine($"Это число с убранной второй цифрой -> {RemoveSecDigit(number)}");