// Task 48.Задайте двумерный массив размером m на n,
//каждый элемент в массиве находится по формуле: Amn=m+n.
// Выведите полученный результат на экран.
// m=3,n=4
// 0123
// 1234
// 2345

Console.WriteLine("Введите количество строк");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int [m, n];
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
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(num1,num2);
PrintMatrix(matrix);