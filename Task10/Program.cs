// Задача 10: Напишите программу, которая 
// 1/принимает на вход трёхзначное число 
//  на выходе показывает вторую / цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(number));

int SecondDigit(int secnum)
{
    int thirddDigit = secnum / 10 % 10;
        return thirddDigit;
}
//   int firstDigit = number % 100;
//     // int secondDigit = number % 100;
//     // int result = firstDigit * 10 + secondDigit;
//     return result;