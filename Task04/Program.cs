// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b && a > c)
{
    max = a;
    Console.WriteLine($"максимальное число {a}");
}
else if (b > c)
{
    max = b;
    Console.WriteLine($"максимальное число {b}");
}
else
    max = c;
Console.WriteLine($"максимальное число {c}");
