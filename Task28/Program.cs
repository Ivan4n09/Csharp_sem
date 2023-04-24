// Задача XVIII
// Напишите программу, которая принимает на вход
// число NB
// и выдает произведение чисел от 1 до N.
// 4 -> 24 = (1*2*3*4)
// 5 -> 120 = (1*2*3*4*5)

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int prodNumbers = CalculateProductOfNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {prodNumbers}");

int CalculateProductOfNumbers(int sequenceLength)
{
    int result = 1;
    for (int currentNumber = 1; currentNumber <= sequenceLength; currentNumber++)
    {
        checked
        {
            result *= currentNumber;
        }
    }
    return result;
}
