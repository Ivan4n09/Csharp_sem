// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// это вариант включающий трехзначные числа меньше 100 (не мой)

// Console.Write("Введите трехзначное число: ");
// string input = Console.ReadLine();
// if (input.Length == 3 && int.TryParse(input, out int number))
// {
//     Console.WriteLine(number%10);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
if (number >= 100 && number <= 999)
    Console.WriteLine(number % 10);
else
    Console.WriteLine("Вы ввели не трёхзначное число");