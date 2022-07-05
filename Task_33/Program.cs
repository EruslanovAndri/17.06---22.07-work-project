// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[5];
var rnd = new Random();
int index = 0;
while (index < array.Length)
{
    array[index] = rnd.Next(-9, 10);
    Console.Write($"{array[index]}  ");
    index++;
}
Console.WriteLine();
int[] Change(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = -arr[i];
        Console.Write($"{newArr[i]}  ");   
    }
    return newArr;
}
int[] array1 = Change(array);