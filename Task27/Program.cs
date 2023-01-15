// Задача 27: Напишите программу, которая 
// 1.принимает на вход число и 
// 2.выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int sumnumbers = SumNumbers(number);
Console.WriteLine($"cумма цифр числа {number} = {sumnumbers}");

int SumNumbers(int digit)
{
    int count = 0;
    while (digit > 0)
    {
        count +=digit % 10;
        digit /= 10;
    }
    return count;

}


