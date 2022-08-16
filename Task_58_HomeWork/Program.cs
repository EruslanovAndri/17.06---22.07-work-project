// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

Console.Clear();
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rowFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int colomnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int rowSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int colomnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

int[,] CreateFirstMarix(int rowFirstMatrix, int colomnsFirstMatrix, int min, int max)
{
    int[,] array = new int[rowFirstMatrix, colomnsFirstMatrix];
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

void PrintFirstMatrix(int[,] arrFirst)
{
    for (int i = 0; i < arrFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrFirst.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arrFirst.GetLength(1) - 1) Console.Write(arrFirst[i, j] + ",");
            else Console.Write(arrFirst[i, j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] CreateSecondMarix(int rowSecondMatrix, int colomnsSecondMatrix, int min, int max)
{
    int[,] array = new int[rowSecondMatrix, colomnsSecondMatrix];
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

void PrintSecondMatrix(int[,] arrSecond)
{
    for (int i = 0; i < arrSecond.GetLength(0); i++)
    {
        for (int j = 0; j < arrSecond.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arrSecond.GetLength(1) - 1) Console.Write(arrSecond[i, j] + ",");
            else Console.Write(arrSecond[i, j] + "]");
        }
        Console.WriteLine();
    }
}


void MultipalTwoMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] thirdMatrix)
{
    for (int i = 0; i < thirdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdMatrix.GetLength(1); j++)
        {
            int res = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                res += firstMatrix[i, k] * secondMatrix[k, j];
            }
            thirdMatrix[i, j] = res;
        }
    }
}
int[,] thirdMatrix = new int[rowFirstMatrix, colomnsSecondMatrix];

int[,] first = CreateFirstMarix(rowFirstMatrix, colomnsFirstMatrix, 1, 10);
Console.WriteLine($"\nПервая матрица");
PrintFirstMatrix(first);
Console.WriteLine();
int[,] second = CreateSecondMarix(rowSecondMatrix, colomnsSecondMatrix, 1, 10);
Console.WriteLine($"\nВторая матрица");
PrintSecondMatrix(second);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
MultipalTwoMatrix(first, second, thirdMatrix);
PrintFirstMatrix(thirdMatrix);

