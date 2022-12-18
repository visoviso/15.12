// 1. Напишите программу, которая 
//1.на вход принимает два  числа 
// 2.проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите целое число: ");

int numbera = Convert.ToInt32(Console.ReadLine());
int numberb =Convert.ToInt32(Console.ReadLine());
int result = numberb * numberb;
if (result == numbera)
{
Console.WriteLine($"Число {numbera} является квадратом числа {numberb} ");
}
else
{
    Console.WriteLine($"Число {numbera}  не является квадратом числа {numberb} ");
    
  }

