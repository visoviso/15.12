// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 20);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write("]");
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) sum += arr[i];
    }
    return sum;
}
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

int[] myArray = CreateArray(3);
PrintArray(myArray);
int getSum = GetSum(myArray);
Console.WriteLine();
Console.WriteLine($"cумма элементов, стоящих на нечётных позициях {getSum}");

