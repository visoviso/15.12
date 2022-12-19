

Console.WriteLine("Введите два числа : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = a % b;

if (result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("остаток от деления" + result);
}
// int number = new Random().Next(100, 100);
// Console.WriteLine($"случайное число из отрезка 100-999 => {number}");

// // int firstDigit = number / 100;
// // int secondDigit = number % 10;
// // int result = firstDigit * 10 + secondDigit;

// int maxDigit2 = RemovesecondDigit(number);
// Console.Write($"два числа, которые будут показаны => {maxDigit2}");

// int RemovesecondDigit(int number)
// {
//     int firstDigit = number / 100;
//     int secondDigit = number % 10;
//     int result = firstDigit * 10 + secondDigit;
//     return result;
// }
