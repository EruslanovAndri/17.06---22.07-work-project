// Task 51: Задайте двумерный массив.
// Найдите сумму элементов находящихся на главной диагонале.
// (с индексами (0,0) (1,1)) и т.д.

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int maxElement = Convert.ToInt32(Console.ReadLine());

int[,] CreatMatrix(int row, int colomns, int min, int max)
{
    int[,] array = new int[row, colomns];
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
            if (j == 0) Console.Write("[ ");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + " | ");
            else Console.Write(arr[i, j] + " ] ");
        }
        Console.WriteLine();
    }

}

int SumOfElementsOnTheMainDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i,j];
            }
        }
    }
    return sum;
}

int[,] matrix = CreatMatrix(row, colomns, minElement, maxElement);
PrintMatrix(matrix);
int sum = SumOfElementsOnTheMainDiagonal(matrix);
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");

// Work