// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// не мой код, более красивый, но я не усвоил новое в нем

// Console.WriteLine("Введите положительное натуральное число: ");
// if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
// {
//     int[] numbers = Enumerable.Range(1, number).ToArray();
//     Console.WriteLine(string.Join(", ", numbers));
// }
// else
// {
//     Console.WriteLine("Вы ввели неправильное число");
// }

// а далее мой

Console.WriteLine("Введите положительное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number > 0)
while (count<=number)
{
    Console.Write(count+", ");
    count++;
    // count = count + 1
    // count += 1
}
else
    Console.WriteLine("Вы ввели неправильное число");