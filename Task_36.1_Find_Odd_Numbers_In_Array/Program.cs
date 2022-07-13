//Task 36. Задайте одномерный массив,заполненный случайными числами.
//Найдите сумму элементов,стоящих на нечетных позициях.
//[3,7,23,12] -> 19
//[-4,-6,89,6] -> 0

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(-100, 100);
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length;
     i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] FindSumOfNumbersOnTheOddIndexPosition(int[] arr)
{
    int oddIndexPositive = 0;
    int oddIndexNegative = 0;
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0 && i > 0)
        {
            oddIndexPositive = oddIndexPositive + arr[i];
        }
        else
        {
            oddIndexNegative = oddIndexNegative - oddIndexPositive;
        }
        res = oddIndexPositive;

    }
    return new[] { res };

}

int[] array = CreateArrayRndInt(10);
PrintArray(array);
int[] res = FindSumOfNumbersOnTheOddIndexPosition(array);
PrintArray(res);
