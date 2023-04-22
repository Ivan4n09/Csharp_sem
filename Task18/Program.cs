// Задача XVIII: Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти (x и y)

 
Console.WriteLine("Введите номер четверти");
int numQuadrant = Convert.ToInt32(Console.ReadLine());

string coordinate = Coordinate(numQuadrant);
System.Console.WriteLine(coordinate == null ? "Ошибка ввода" : coordinate);

string Coordinate(int num)
{
    if(num == 1) return "x > 0, y > 0";
    if(num == 2) return "x < 0, y > 0";
    if(num == 3) return "x < 0, y < 0";
    if(num == 4) return "x > 0, y < 0";
    return null;
}

// double d = Math.Round(Math.Sqrt(5), 2);

// double d1  = 5.09987654;
// double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
// Console.WriteLine(d);