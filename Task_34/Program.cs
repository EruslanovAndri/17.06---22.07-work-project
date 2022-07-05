// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(100, 1000);
        index++;
    }
    return array;
}
int[] PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i >= 1000) Console.Write(array[i]);
        else Console.Write(array[i] + " ");
    }
    return array;
}
int[] array = CreateNewArray(3);
PrintArray(array);

int FindEvenNumber(int[] arr)
{
    int evenNumbers = 0;
    int div = 2;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr.Length)
        {
            evenNumbers = arr[i] / div + evenNumbers;
        }

    }
    return evenNumbers;
}

int findEvenNumber = FindEvenNumber(array);
