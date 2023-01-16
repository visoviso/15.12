// Задача 29: Напишите программу, которая 
// 1.задаёт массив из 8 элементов 
// 2.выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[] { 1, 2, 5, 7, 19, 6, 1, 33 };
Fillarray(array);
// PrintArray(array);

void Fillarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

}
