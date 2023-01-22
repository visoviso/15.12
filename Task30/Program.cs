// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int[] array = new int [8]; 0,1,2,3,4,5,6,7
// array[0] =235;
// array[1] =455;
// array[2] =5;
// array[3] =56;
// array[4] =25;

// System.Console.Writeline(array[2]);
// for (int i=0, i< array.Length; i++)
// {
//     array[i]=2;
// }


int[] array = new int[8]; // 0,1,2,3,4,5,6,7

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
