// Task 38. Массив с вещественными числами.Найти 
// разницу между максимальным и минимальным элементом массива.

double[] CreateArrayRndDouble()
{
    double[] array = new double[5];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.NextDouble() * 100;
        index++;
    }
    return array;
}
void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

double FindDifferenceBetweenMaxAndMinElements(double[] arr)
{
    double maxElement = 0;
    double minElement = 0;
    double result = 0;


    for (int i = 0; i < arr.Length; i++)
    {
        if (maxElement <= arr[i])
        {
            maxElement = arr[i];

        }
        else
        {
            minElement = arr[i];
        }
        result = maxElement - minElement;
    }
    return result;
}

double[] array = CreateArrayRndDouble();
PrintArray(array);
double res = FindDifferenceBetweenMaxAndMinElements(array);
Console.WriteLine(Math.Round(res, 3));