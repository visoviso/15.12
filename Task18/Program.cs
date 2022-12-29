// по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти ( xи y)



// int quarter = Quarter(x, y);
// string result = quarter > 0
//                        ? $"Указанные координаты соответствуют четверти -> {quarter}"
//                        : "введены некорректные координаты";
// Console.WriteLine(result);

Console.WriteLine("номер четверти(1-4): ");
string quarter = Console.ReadLine();
string result = Coordinate(quarter);
Console.WriteLine(result);

string Coordinate(string num)
{
if (num == "1") return "x > 0 && yc > 0";
if (num == "2") return "x > 0 && yc > 0";
if (num == "3") return "x > 0 && yc > 0";
if (num == "4") return "x > 0 && yc > 0";
return "неверный номер четверти";
}

// void Coordinate(int number)
// {
//     if (number == 1)
//     {
//         Console.WriteLine("c > 0 && yc > 0");
//     }
//     else if (number == 2)
//     {
//         Console.WriteLine("xc < 0 && yc > 0");
//     }
//     else if (number == 3)
//     {
//         Console.WriteLine("xc < 0 && yc < 0");
//     }
//     else if (number == 4)
//     {
//         Console.WriteLine("xc > 0 && yc < 0");
//     }
//     else Console.WriteLine(" не номер четверти");

// }
// Coordinate(number);
