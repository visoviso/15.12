// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] CreateArray (int size)
{
    int[] array =  new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (-100, 200);
    }
    return array;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
        Console.Write("]");
}

int NumberElements (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] < 100) && (array[i] > 9)) count++;
    }
    return count;
}


int[] myArray = CreateArray(10);
PrintArray (myArray);
int myCount = NumberElements(myArray);
Console.WriteLine();
Console.WriteLine($"In this array number of elements from 10 to 99 is {myCount}.");


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
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
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");

//     int NumberElements(int[] array)
//     {
//         int count = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (array[i] < 100 && (array[i] > 9)) count++
//             else Console.Write(arr[i]);
//         }

//     }    {   }    int[] MyArray = CreateArray(10)
//     PrintArray(MyArray)
// // }
// // int GetSumPositiveElem(int[] arr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         if (arr[i] > 0) sum += arr[i];
// //     }
// //     return sum;
// // }

// // int GetSumNegativElem(int[] arr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         if (arr[i] < 0) sum += arr[i];
// //     }
// //     return sum;
// // }
// // int[] GetSumPositiveNegativElem(int[] arr)
// // {
// //     int sumNeg = 0;
// //     int sumPos = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         if (arr[i] > 0) sumPos += arr[i];
// //         else if (arr[i] < 0) sumNeg += arr[i];
// //     }

// //     return new int[]{sumPos, sumNeg};
// // }
// // // int sumPositive = GetSumPositiveElem(array);
// // // int sumNegative = GetSumNegativElem(array);

// // Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// // Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

// // int[] sumPositiveNegative = GetSumPositiveNegativElem(array);

// // Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
// // Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");
