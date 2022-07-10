// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0,100);
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] CopyArray(int [] arr)
{
           int[] newArray = new int[arr.Length];
           for (int i = 0; i < arr.Length; i++)
           {
                newArray[i] = arr[i];
           }
           return newArray;
}

int[] array = CreateArrayRndInt(6);
PrintArray(array);
int[] result = CopyArray(array);
Console.WriteLine();
PrintArray(result);