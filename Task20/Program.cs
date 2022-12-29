// принимает на вход координаты двух точет и находит расстояние между ними в 2d пространстве
// a (3,6) b(2, 1)

Console.WriteLine("Please, enter coordinates of two segments : ");
Console.WriteLine("XA : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("XB : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YA : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YB : ");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, xb, ya, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Distance beteen segments with coordinates {xa} , {xb} and {ya}, {yb} is {ourDistance}.");


double Distance (int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2));
    return distance;
}


// Console.WriteLine("введите координеты точки A ");

// Console.Write("X:");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y:");
// int ay = Convert.ToInt32e(Console.ReadLine());
// Console.WriteLine("введите координеты точки B ");

// Console.Write("X:");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y:");
// int by = Convert.ToInt32(Console.ReadLine());


// int Distance(int x1, int y1, int x2, int y2)
// {
//     int legX = x2 - x1;
//     int legY = y2 - y1;
//     int hypotenuse = legX * legX + legY * legY;
//     return hypotenuse;

// }

// double sqtr = Math.Sqrt(Distance())

// Math.Pow(2, 2);
// double d = Math.Sqrt(355);

// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);


// Console.WriteLine("Please, enter coordinates of two segments : ");
// Console.WriteLine("XA : ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("XB : ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YA : ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YB : ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double ourDistance = Math.Round(Distance(xa, xb, ya, yb), 2, MidpointRounding.ToZero);
// Console.WriteLine($"Distance beteen segments with coordinates {xa} , {xb} and {ya}, {yb} is {ourDistance}.");


// double Distance (int x1, int x2, int y1, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2));
//     return distance;
// }
