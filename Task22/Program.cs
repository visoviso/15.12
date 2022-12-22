// принимает на вход число N и выдает таблицу квадратов числе от 1 до N
Console.Write("Введите числа: ");
int number = Convert.ToInt32(Console.ReadLine());

Quarter(number);

void Quarter(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index} {index * index}");
        index ++;
    }
    // for (int i = 1; i <= n; i++)
    // {
    //     while
    //     }
}

// onsole.WriteLine("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 == 0)
//         Console.WriteLine(i);
// }
// int index = 1
