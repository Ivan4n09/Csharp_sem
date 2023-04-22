// Задача XIX
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите пятизначное число > ");
if (ValidateNumber(number))
{
    if (PalindromeCheck(number))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

int Prompt(string input)
{
    Console.Write(input);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int num)
{
    if (Math.Abs(num) < 10000) // Math.Abs - абсолютное значение, напр. абс. знач. -5 = 5
    {
        System.Console.WriteLine("Не пятизначное число");
        return false;
    }
    return true;
}

bool PalindromeCheck(int ourNum)
{
    if(GetFirstDigit(ourNum) == GetFifthDigit(ourNum) && GetSecondDigit(ourNum) == GetFourthDigit(ourNum))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetFirstDigit(int num)
{
    num = num / 10000;
    return num;
}

int GetSecondDigit(int num)
{
    num = num / 1000;
    return num%10;
}

int GetFourthDigit(int num)
{
    num = num % 100;
    return num / 10;
}

int GetFifthDigit(int num)
{
    return num % 10;
}

// проверка, работают ли методы
// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int res = GetSecondDigit(number);
// System.Console.WriteLine(res);























