// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

//мысли: итак, введены два числа. Если число1 поделить на число2 равно число1 то это да,
//является квадратом. А если нет, то нет.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваши числа {numberA} и {numberB}");

if (numberA== numberB*numberB){
    Console.WriteLine($"Да, число {numberA} является квадратом {numberB}");
}
else{
    Console.WriteLine($"Нет, число {numberA} не является квадратом {numberB}");
}