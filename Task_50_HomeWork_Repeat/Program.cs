// Task50. Напишите программу , которая на вход примимает позицию элемента 
// в двумерном  массиве
// и выводит значение этого элемента на экран, или пишет что такого элемента нет.

Console.Clear();
Console.WriteLine("Программа показывающая элемент, который находится по заданным координатам.");
Console.WriteLine();
Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int maxElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в строке: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в столбце: ");
int colomnsIndex = Convert.ToInt32(Console.ReadLine());

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

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" [ ");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + " | ");
            else Console.Write(array[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

int FindElement(int[,] array)
{
    int res = array[rowIndex, colomnsIndex];
    if (rowIndex < array.GetLength(0) && colomnsIndex < array.GetLength(1) && rowIndex! < 0 && colomnsIndex! < 0)
    {   
        res = array[rowIndex, colomnsIndex];
    }
    else 
    {
        
    }
    return res;    
}

int[,] matrix = CreatMatrix(row, colomns, minElement, maxElement);
PrintMatrix(matrix);
int res = FindElement(matrix);
Console.WriteLine($"Элемент массива по заданным координатам = {res}");

// Work 