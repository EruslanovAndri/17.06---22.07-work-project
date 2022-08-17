// SeletionSort Matrix From Max To Min
Console.Clear();
Console.WriteLine("Rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Colomns");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] CreatMatrix(int rows, int colomns)
{
    int[,] array = new int[rows, colomns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" [ ");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + " , ");
            else Console.Write(array[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

void SelectionSortArrayFromMaxToMin(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {

        for (int i = 0; i < array.GetLength(1); i++)
        {
            int maxPos = i;

            for (int j = i; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, maxPos])
                {
                    maxPos = j;
                }
            }
            int temp = array[k, i];
            array[k, i] = array[k, maxPos];
            array[k, maxPos] = temp;
        }
    }
}

int[,] matrix = CreatMatrix(rows, colomns);
PrintArray(matrix);
SelectionSortArrayFromMaxToMin(matrix);
Console.WriteLine();
PrintArray(matrix);

//Work