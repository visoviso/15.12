﻿int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");




int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.Write($"Наибольшая цифра числа => { result}");
