// // Задача 15: Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, 
// 2.и проверяет является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void Holiday(int day) 
{
  if (number == 6 || number == 7) 
  {
  Console.WriteLine("да");
  }
  else if (number <= 1 || number >= 7) 
  {
    Console.WriteLine("не день недели");
  }
  else Console.WriteLine(" нет");
}
Holiday(number);



