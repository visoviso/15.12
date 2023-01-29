// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Dictionary (int[] array)
{
    int number = array[0];
    int count = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else 
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }    
    }
    Console.WriteLine($"{number} -> {count}");
}
}