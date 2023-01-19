// / Задача 33: Задайте массив. Напишите программу, которая
// // определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // 3; массив [6, 7, 19, 345, 3] -> да
// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());

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
//     Console.Write("]");
// }

// bool CheckingNumber(int num, int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num) return true;

//     }
//     return false;
// }

// int[] array = CreateArrayRndInt(4, -8, 8);
// PrintArray(array);
// CheckingNumber(array);
// PrintArray(array);

bool IsExistNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.Write("Введите число, которое хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isExistNum = IsExistNum(array, number);
if (isExistNum)
{
    Console.Write($"Число {number} есть в массиве - ");
    PrintArray(array);
}
else
{
    Console.Write($"Числа {number} нет в массиве - ");
    PrintArray(array);
}
