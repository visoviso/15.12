// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, что третьей
// // цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ThirdDigit(number));

int ThirdDigit(int number)
{
    if (number >= 100)
    {
        while (number > 999)
        {
           number = number / 10; 
        }
        number = number % 10;
        return number;
    }
      else 
      return number =-1;
}
