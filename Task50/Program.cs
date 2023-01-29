// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("введите 1-ю позицию элемента в двухмерном массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-ю позицию элемента в двухмерном массиве: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];

void CreateMatrixRndInt(int[,] array)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(10,20);
        }
    }
   
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
    
}
CreateMatrixRndInt(matrix);
PrintMatrix(matrix);

        if (a < matrix.GetLength(0) && b < matrix.GetLength(1))
        {
            Console.WriteLine($" значение элемента массива {matrix[a, b]}");
        }
        else
        {
            Console.WriteLine($" такого элемента нет в массиве");
        }
 

