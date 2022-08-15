// Создание и печать двумерного массива.

int[,] CreatMatrixRndInt(int row, int colomns, int min, int max)
{
    int[,] array = new int[row,colomns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min,max);
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
            if(j == 0) Console.Write("[ ");
            if(j < arr.GetLength(1) - 1)Console.Write(arr[i,j] + " | ");
            else Console.Write( arr[i,j] + " ] ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreatMatrixRndInt(4,4,10,50);
PrintMatrix(matrix);

// work