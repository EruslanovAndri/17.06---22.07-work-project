// Task 47. Задайте двумерный массив размером m x n, 
// который заполненый вещественными числами.
// m = 3, m = 4.
// 0,5 7 -2 -0,2
// 1,-3,3 9, -9,9

Console.WriteLine("Введите количество строк: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
double num2 = Convert.ToInt32(Console.ReadLine());

double[,] CreateArrayRandomDouble(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble(), 2);
        }
    }
    return array;
}

void PrintArrayDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" [ ");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + " | ");
            else Console.Write(arr[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateArrayRandomDouble(5, 5, 30, 40);
PrintArrayDouble(matrix);





