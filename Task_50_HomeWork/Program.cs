// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Введите количество сторок в двумерный массив: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерный массив: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int maxElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int num5 = Convert.ToInt32(Console.ReadLine());

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

int FindElement(int[,] arr)
{
    int res = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == num4 && j == num5)
            {
                res = arr[i, j] = arr[i, j];
            }
        }
    }
    return res;
}

int[,] matrix = CreateMarix(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
int res = FindElement(matrix);
Console.WriteLine($"На заданной позиции находится число {res}.");


// Work. Только пока не понятно как сделать чтобы программа писала, что такого номера нет если 
// матрица меньше чем номер искомой позиции.