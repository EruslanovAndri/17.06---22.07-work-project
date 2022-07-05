// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 200);
        Console.Write(array[index] + " ");
        index++;
        
    }
    return array;
}
int[] array1 = CreateArrayRndInt(5);


int FindNum(int[] arr)
{
    int i = 0;
    int count = 0;
    while (i < arr.Length)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count = count + 1;
        i++;
        
    }
    return count;
}

int count1= FindNum(array1);
Console.WriteLine();
Console.WriteLine(count1);