// XVII. Напишите программу, которая
// 1. Принимает на вход координаты точки (X и Y)
// 2. причем X и Y не равны нулю и
// 3. Выдает номер четверти плоскости, в которой находится точка

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoord, yCoord);
string result = quarter > 0
                ? $"Указанные координаты соответсвуют четверти {quarter}"
                : "Введены неверные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

