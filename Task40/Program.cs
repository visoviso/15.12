// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.WriteLine("введите 1-е число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2-е число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 3-е число ");
int number3 = Convert.ToInt32(Console.ReadLine());
// IsExistTriangle(number1, number2, number3);
// Console.WriteLine(IsExistTriangle);
bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Такой треугольник существует" : "Такого треульгоника не существует");

bool IsExistTriangle(int num1, int num2, int num3)
{
    int sum1 = num1 + num2;
    int sum2 = num1 + num3;
    int sum3 = num2 + num3;
    if (sum1 > num3 && sum2 > num2 && sum3 > num1) return true;
    else return false;
}
// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(BothMultiple(number) ? "Да" : "Нет");

// bool BothMultiple(int num, int num1 = 7, int num2 = 23)
// {
//     return num % num1 == 0 && num % num2 ==0;
// }
