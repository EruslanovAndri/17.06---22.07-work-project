Console.Clear();

double[] CreatArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        index++;
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i] + "]");
    }
}
double[] array = CreatArrayRndDouble(5,100,1000);
PrintArray(array);