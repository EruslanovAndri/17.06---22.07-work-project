// Task 49: Задать двумерный массив.
// Найти элементы, у которых оба индекса четные
// и заменить эти элементы на их квадраты.
//   index     [0] [1] [2] [3] [4]       [0] [1] [2] [3] [4] 
//elements [0]  2   5   7   4   3     [0] 4   5   7   4   3
//         [1]  4   5   6   3   2     [1] 4   5   6   3   2
//         [2]  6   3   8   2   1     [2] 
//         [3]  2   2   6   4   5     [3]
//         [4]  5   1   5   7   6     [4]

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
void ChangeEvenIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
    
}
int[,] matrix = CreatMatrix(row, colomns, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
ChangeEvenIndex(matrix);
PrintMatrix(matrix);

// Work