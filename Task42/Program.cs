// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// string res = ConvrtDecToBin(2);
// Console.WriteLine(res);

// string ConvrtDecToBin(int num)
// {
//     int result = string.Empty;

//     while (num > 0)
//     {
//         result = num % +result;

//         num = num / 2;
//     }
//     return result;
// }
string res = ConvertDecToBin(13);
Console.WriteLine(res);

string ConvertDecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
