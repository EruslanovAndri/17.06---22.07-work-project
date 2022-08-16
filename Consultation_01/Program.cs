// Задача 54: // Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMarix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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

void PutNumbersInARowFromMaxToMIn(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int maxPos = i;

            for (int j = i; j < arr.GetLength(1); j++)
            {
                if (arr[k, j] > arr[k, maxPos])
                {
                    maxPos = j;
                }
            }
            int temp = arr[k, i];
            arr[k, i] = arr[k, maxPos];
            arr[k, maxPos] = temp;
        }
    }
}



int[,] matrix = CreateMarix(num1, num2, 10, 100);
PrintMatrix(matrix);
PutNumbersInARowFromMaxToMIn(matrix);
Console.WriteLine();
PrintMatrix(matrix);













