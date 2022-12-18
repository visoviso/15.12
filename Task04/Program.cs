// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите целое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
int numberb = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numbera > numberb)
{
    max = numbera;
    Console.WriteLine($"максимальное число{numbera}");
}
else
    Console.WriteLine($"максимальное число {numberb}");
{

}
