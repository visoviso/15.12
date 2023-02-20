// Задача 66: 

// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(number1, number2);
if (NumbersCheck(number1, number2)) Console.Write(result);
else Console.WriteLine("не натуральное число");

int SumNumber(int num1, int num2)
{
    if (num1 < num2) return num1 + SumNumber(num1 + 1, num2);

    if (num1 > num2) return num1 + SumNumber(num1 - 1, num2);

    if (num1 == num2) return num1;

    return num1;
}
bool NumbersCheck(int num1, int num2)
{
    return (num1 > 0 && num2 > 0);
}