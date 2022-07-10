// Task 34. Здайте массив заполненый случайными трехзначнеными числами.
// Напишите программу,которая покажет количество четных чисел.

int[] CreateArrayRndInt(int size)
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] SumOfEvenNumbersInArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count = count + 1;
    }
    return new[] { count };
}

int[] array = CreateArrayRndInt(10);
PrintArray(array);
int[] res = SumOfEvenNumbersInArray(array);
Console.WriteLine();
PrintArray(res);

//Work

// Не могу понять как вывести сообщение в консоль о том, что результат равен = res. Табуляция не помогает.




