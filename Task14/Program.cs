// XIV. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23. (или введенным другим числам, как я сделал)
// (Или еще двум введенным множителя м)

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первый множитель");
int multipleA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй множитель");
int multipleB = Convert.ToInt32(Console.ReadLine());

bool result = MultipleTwoNums(number,multipleA,multipleB);

Console.WriteLine(result ? "Да, число кратно обоим множителям" : "Нет, число не кратно обоим множителям");

bool MultipleTwoNums (int num, int num1, int num2)
{
    return num%num1 == 0 && num%num2 == 0;
}

// bool - это тру или фолс
// тут (в методе MultipleTwoNums) проверяется, кратно ли число 7 и 23 (равен (==) ли остаток от деления на 7 и (&&) на 23 нулю)