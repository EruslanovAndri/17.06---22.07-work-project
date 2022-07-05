// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = {-4,-8,8,2};
int index = 0;

while (index < array.Length)
{
    array[index] = array[index] * -1;
    index++;
}
void PrintArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i] + "]");    
}
}
PrintArray(array);

