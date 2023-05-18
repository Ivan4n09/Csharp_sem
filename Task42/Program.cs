// Задача 42: Программа, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 - > 11
// 2 - > 10 (остаток от деления на два)

Console.WriteLine("Введите целое положительное число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
if(inputNumber > 0)
Console.WriteLine($"Число {inputNumber} в двоичном формате - {ConvertDecimalToBinary(inputNumber)}");
if(inputNumber == 0)
Console.WriteLine("Число 0 в двоичном формате - 0");
else
Console.WriteLine("Incorrect input number");

int ConvertDecimalToBinary (int num)
{
    int count = 1;
    int result = 0;
    while(num > 0)
    {
        result += num % 2 * count;
        num /= 2;
        count = count * 10;
    }
    return result;
}

// короткий вариант

// string binaryString = Convert.ToString(inputNumber, 2);
// Console.WriteLine($"Число {inputNumber} в двоичном формате - {binaryString}");