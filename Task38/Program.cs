// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

// static void GetSum(int[] arr)
// {
//     int max = 0;
//     int min = 0;
//     int result = max - min;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         if (arr[i] < min) min = arr[i];
//         {
//             min = arr[i];
//         }
//     }
// Console.WriteLine ($"{result}");

// }
// //     }
// //     if (min > 0 && max > 0)
// //     {
// //         result = max - min;
// //     }
// //     return result;
// // }

int[] array = CreateArrayRndInt(3, -1, 5);
PrintArray(array);
int max = Max(array);
int min = Min(array);
int dif = max - min ;

Console.WriteLine($"разность мин и макс элементов = {dif}");

