// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");

if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}