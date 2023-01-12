using Internal;
using System;
// адача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("введите целове число");
// int number = Convert.ToInt32(Console.ReadLine());
// // int number1 = int.Parse(Console.Readline());
// int sumNumbers = SumNumbers(number);
// Console.WriteLine($"сумма числе от 1 до {number} = {sumNumbers}");
// int SumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//         // sum = sum+i
//     }
//     return sum;
// }
Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}
