// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
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

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
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

int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int[,] arr = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0))
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    arr[i, j] += a[i, k] * b[k, j];
                }
            }
        }
    return arr;
}
int[,] createMatrixRndInt1 = CreateMatrixRndInt1(1, 2, 1, 3);
PrintMatrix(createMatrixRndInt1);
Console.WriteLine(" ");

int[,] createMatrixRndInt2 = CreateMatrixRndInt2(1, 2, 1, 2);
PrintMatrix(createMatrixRndInt2);
Console.WriteLine(" ");

int[,] matrixMultiplication = MatrixMultiplication(createMatrixRndInt1, createMatrixRndInt2);
PrintMatrix(matrixMultiplication);

