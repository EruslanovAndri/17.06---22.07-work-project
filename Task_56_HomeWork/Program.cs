// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка


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

int[,] FindLineWithMinSumElements(int[,] arr)
{
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > arr.GetLength(0) && arr[i, j] > arr.GetLength(1))
            {
                sumElement += arr[i, j];
                k = sumElement;
            }
        }
        Console.WriteLine($"Sum all elements in each line = {sumElement}");
    }
    return arr;
}

int[,] matrix = CreateMarix(num1, num2, 10, 100);
PrintMatrix(matrix);
int[,] result = FindLineWithMinSumElements(matrix);
Console.WriteLine(result);

// Могу вывести результат в каждой строке, 
//но не могу понять как сравнить полученный 
//результат и найти строку с минимальным результатом.
// Объясните пожалуйста!!!