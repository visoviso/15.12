// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double Getx(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k1 - k2);
    return x;
}

double Gety(double x, double k2, double b2)
{
    double y = k2 * x + b2;
    return y;
}

if (k1 != k2)
{
    double getx = Getx(b1, k1, b2, k2);
    double gety = Gety(getx, k2, b2);
    ;
    Console.WriteLine($"две прямые пересекутся в точке: {getx}, {gety}");
}