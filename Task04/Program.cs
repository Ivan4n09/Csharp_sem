// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());

int max = numberA;

// if (numberA > max ) max = numberA;   - лишнее условие. 
// Либо можно было написать int max = 0 (а не int max = numberA)

if (numberB > max ) max = numberB;
if (numberС > max ) max = numberС;

Console.Write("Наибольшее из этих чисел - ");
Console.WriteLine(max);