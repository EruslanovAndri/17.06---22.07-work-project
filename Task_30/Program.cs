// Задача 30: Программа, которая выводит массив из 8 элементов, заполненый нулями и 
//единицами в случайном порядке.
// [1,0,1,0,1,1,0,0,]

int[] array = new int[8];
int[] array1 = {3,5,8,5,3,8,9,3,1,};
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index = 0;
var rnd = new Random();

while (index < array.Length)
{
    array[index] = rnd.Next(0, 2);
    index++;
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < array.Length - 1) Console.Write(array[i] + ",");
    else Console.Write(array[i] + "]");

    
}