

//  Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите число ");
string number = Console.ReadLine();
int leng = number.Length;
void Checknum(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число {number} - палиндром.");
  }
  else Console.WriteLine($"Число {number} - не палиндром.");
}

if (number.Length == 5)
{
  Checknum(number);
}
else Console.WriteLine($"Введи правильное число");