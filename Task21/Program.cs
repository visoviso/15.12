// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Please, enter coordinates of two segments : ");
Console.WriteLine("A : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B : ");
int b = Convert.ToInt32(Console.ReadLine());


double ourDistance = Math.Round(Distance(a, b), 2, MidpointRounding.ToZero);
Console.WriteLine($"Distance beteen segments with coordinates {a} , {b}  is {ourDistance}.");


double Distance(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}

