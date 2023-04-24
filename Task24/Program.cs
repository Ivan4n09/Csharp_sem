// Задача XXIV: Напишите программу, которая
// 1. принимает на вход число (А)
// 2. выдает сумму чисел от 1 до А
// 7 - > 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
// !NB - у Int32 есть максимум, поэтому эта программа на будет считать большие числа (больше 2,147,483,647)


int SumNumbers(int num) // int num = number (см. строку 12)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked         // делает проверку на слишком большое число
        {
            sum += i; // sum = sum + i и напр.: sum /= 2 то же самое что sum = sum /2
        }
    }
    return sum;
}
