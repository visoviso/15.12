﻿Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(BothMultiple(number) ? "Да" : "Нет");

bool BothMultiple(int num, int num1 = 7, int num2 = 23)
{
    return num % num1 == 0 && num % num2 ==0;
}

