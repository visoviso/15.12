// Задача 34: 
// 1 Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2 Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0) sum ++;
    }
    return sum;
}

int[] array = CreateArray(3);
PrintArray(array);
int getSumPositive = GetSumPositive(array);
Console.WriteLine($"количество положительных элементов = {getSumPositive}");

