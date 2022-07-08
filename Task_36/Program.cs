//Задача 36: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = { 2, 1, 2, 3, 5, 6, 7 };
int[] ProizvedSideNUmbers(int[] arr)
{

    // if (arr.Length % 2 == 0)
        int[] newArr = new int[arr.Length / ];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
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
PrintArray(array);
Console.WriteLine();
int[] newArray = ProizvedSideNUmbers(array);
PrintArray(newArray);

// Work
