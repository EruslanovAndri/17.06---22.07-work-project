int[] CreatArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(1, 1000);
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(" [ ");
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.Write(arr[i] + " ] ");
    }
}

int[] PutInARowAllElementsFromMaxToMin(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int maxElement = i;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] <= arr[maxElement])
            {
                maxElement = j;
            }
            else
            {
                int temp;
                temp = arr[maxElement];
                arr[maxElement] = arr[i];
                arr[i] = temp;
            }
        }
    }
    return arr;
}


int[] array = CreatArrayRndInt(5);
PrintArray(array);
int[] result = PutInARowAllElementsFromMaxToMin(array);
Console.WriteLine();
PrintArray(result);
