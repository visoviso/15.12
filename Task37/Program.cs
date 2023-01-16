﻿using System;
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}


// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write("]");
// }
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


int[] MultiplyElements(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size = size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        // newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        if (i != arr.Length - 1 - i)
            newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else newArr[i] = arr[i];
    }
    return newArr;
    // for (int i = 0; i < size; i++)
    // {
    //     if (i != arr.Length - 1 - i)
    //         multiplyArray[i] = arr[i] * arr[arr.Length - 1 - i];
    //     else multiplyArray[i] = arr[i];
    // }
}
int[] array = CreateArray(8);
PrintArray(array);
int[] newArray = MultiplyElements(array);
PrintArray(newArray);


