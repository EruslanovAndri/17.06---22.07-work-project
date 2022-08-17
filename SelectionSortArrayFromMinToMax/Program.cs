// SeletionSort Matrix From Min To Max

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
void SelectionSortArrayFromMinToMax(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {


            for (int j = i; j < array.GetLength(1); j++)
            {
                int minPos = i;
                
                if (array[k, j] < array[k, minPos])
                {
                    minPos = j;
                }
                int temp = array[k, i];
                array[k, i] = array[k, minPos];
                array[k, minPos] = temp;
            }

        }

    }
}
int[,] matrix = CreatMatrix(rows, colomns);
PrintArray(matrix);
SelectionSortArrayFromMinToMax(matrix);
Console.WriteLine();
PrintArray(matrix);

//Work