// Задача XXI
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double d = Math.Round(Math.Sqrt(5), 2);
// double d1  = 5.09987654;
// double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
// Console.WriteLine(d1Round);
// Console.WriteLine(d);


double DistanceBetweenPoints(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distance;
}

Console.WriteLine("Введите координаты точки А ");
Console.Write("Xa: ");
int xACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Ya: ");
int yACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Za: ");
int zACoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");

Console.Write("Xb: ");
int xBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Yb: ");
int yBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Zb: ");
int zBCoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceBetweenPoints(xACoord, yACoord, zACoord, xBCoord, yBCoord, zBCoord);

double distRound = Math.Round (distanceAB, 2, MidpointRounding.ToZero);

System.Console.WriteLine(distRound);