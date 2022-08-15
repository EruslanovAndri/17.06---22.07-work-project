// Задача 48: Задать двумерный массив размером m x n,
// каждый элемент в массиве находится по формуле Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreatMatrix(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + " | ");
            else Console.Write(arr[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreatMatrix(m, n);
PrintMatrix(matrix);

// work