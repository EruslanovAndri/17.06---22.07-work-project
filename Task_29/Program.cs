// Задача 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int [] array = {1,2,3,4,5,6,7,8,};

void PrintArray(int []arr)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine();
}
PrintArray(array);