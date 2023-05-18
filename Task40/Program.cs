// Задача 40: Напишите программу, которая принимает
// на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона стреугольника меньше
// суммы двух сторон.

Console.WriteLine("Введите сторону А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону В");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону С");
int numberC = Convert.ToInt32(Console.ReadLine());

bool IsTriangle (int numA, int numB, int numC)
{
    if(numA < numB + numC && numB < numA + numC && numC < numA + numB)
    return true;
    else return false;
}

Console.WriteLine(IsTriangle(numberA, numberB, numberC) ? "Can be a triangle" : "Can not be a triangle" );