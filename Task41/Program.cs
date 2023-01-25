// ДЗ
// Задача 41: 
// 1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы через запятую: ");
int[] input = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0) count++;
}
Console.WriteLine($"Кол-во элементов больше нуля: {count}");
