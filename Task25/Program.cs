using System;
using System.ComponentModel;
// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B) 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А");
Console.WriteLine("Введите число B");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int exponent = Exponent(number1, number2);
Console.WriteLine($"число {number1} в степене {number2} ={exponent}");

int Exponent(int a, int b)
{
    int sum = Convert.ToInt32(Math.Pow(a, b));
    return sum;
}
