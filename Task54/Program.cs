﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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

int[,] BubbleSort(int[,] newArray)
{
    int temp=0;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1) - 1; j++)
        {
            for (int a = 0; a < newArray.GetLength(1) - 1 - j; a++)
            {
                if (newArray[i, a] < newArray[i, a + 1])
                {
                    temp = newArray[i, a];
                    newArray[i, a] = newArray[i, a + 1];
                    newArray[i, a + 1] = temp;
                }
            }
        }
    }
    return newArray;
}


int[,] matrix = CreateMatrixRndInt(3, 4, 10, 20);
PrintMatrix(matrix);
Console.WriteLine("Сортировка элементов в строках от большего к меньшему: ");
int[,] newArray = BubbleSort(matrix);
PrintMatrix(newArray);

