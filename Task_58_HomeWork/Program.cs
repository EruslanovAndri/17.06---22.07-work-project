// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

Console.WriteLine("Введите количество строк для матрицы А:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы А:");
int num2 = Convert.ToInt32(Console.ReadLine());


int[,] CreateMarixA(int m, int n, int min, int max)
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

void PrintMatrixA(int[,] arr)
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

int[,] matrixA = CreateMarixA(num1, num2, 10, 100);



Console.WriteLine("Введите количество строк для матрицы В:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы В:");
int num4 = Convert.ToInt32(Console.ReadLine());

int[,] matrixB = CreateMarixB(num3, num4, 10, 100);

int[,] CreateMarixB(int m, int n, int min, int max)
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


void PrintMatrixB(int[,] arr)
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

int MultiplicationTwoMatrix(int[,] matrixC)
{
    int[,] result = 0;
    for (int i = 0; i < matrixA.Length; i++)
    {
        for (int j = 0; j < matrixB.Length; j++)
        {
            result = matrixA[i, j] * matrixB[i, j] + matrixA[j + 1] * matrixB[i + 1];
        }
    }
    return result;
}



PrintMatrixA(matrixA);
Console.WriteLine();
PrintMatrixB(matrixB);
int newMatrix = MultiplicationTwoMatrix(matrixC);
PrintMatrixA(newMatrix);
