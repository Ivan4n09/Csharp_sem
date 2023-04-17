// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number > 0)
while (count<=number)
{
    Console.Write(count+", ");
    count += 2;
    // count = count + 2
}
else
    Console.WriteLine("Вы ввели неправильное число");

// Конечно, это просто упражнение, но хочется обусловить все максимально