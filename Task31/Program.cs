﻿// Задача 31: 
// 1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// 2.Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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
    Console.WriteLine("]");
}
// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int GetSumNegativElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }
int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else if (arr[i] < 0) sumNeg += arr[i];
    }

    return new int[]{sumPos, sumNeg};
}
// int sumPositive = GetSumPositiveElem(array);
// int sumNegative = GetSumNegativElem(array);

// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumPositiveNegative = GetSumPositiveNegativElem(array);

Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");



// int[] CreateArrayRndInt(int size, int min, int max);
// {
//     int[] arr = new int[size];
//     var rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.WriteLine(arr[i] + ",");
//         else Console.WriteLine(arr[i]);
//     }
//     Console.WriteLine("[");
// }

// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//           }
//      return sum;
//     }

// int GetSumnegativeElem(int[] arr)
// {
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0) sum += arr[i];
//     return sum;
// }
// }


// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// int sumPositive = GetSumPositiveElem(array);
// int sumNegative = GetSumnegativeElem(array);
// Console.WriteLine($"Сумма положительны элементов  ={sumPositive}");
// Console.WriteLine($"Сумма пjnhbwfntkmys[] элементов  ={sumNegative}");