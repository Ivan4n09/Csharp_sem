// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string input)
{
    Console.Write(input);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10; // обозначает поделить на десять и присвоить значение - короткое обозначение
    }
    return num % 10;
}

bool ValidateNumber (int num) // проверяет, не меньше ли введенное число ста
{
    if (num < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    System.Console.WriteLine(GetThirdDigit(number));
}




// неправильный код
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// Console.WriteLine("Третьей цифры нет");
// else
// if (number > 999)
// {
//     number = number / 10;
// }
// int result = ShowThirdDigit(number);
// Console.Write(result);
// int ShowThirdDigit (int num)
// {
//     return num % 10;
// }