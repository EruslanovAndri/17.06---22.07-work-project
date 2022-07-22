// Задача 72: Заданы 2 массива: data  и info. В массиве data хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве info хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1,1,0,1,1,1 };
int[] info = { 2, 3, 3, 6 };

//int[] result = new int[info.Length];// - новій массив 
int k = 0; // счетчик количества цифр в data
for (int i = 0; i < info.Length; i++) //разбиваем data на числа в двоичном коде на основе количества бит из info
{
    int[] result = new int[info[i]];
    for (int j = 0; j < info[i]; j++)
    {
        //Console.Write(data[k + j] + " ");
        result[j] = data[k + j];
    }
    k += info[i];
    // Console.Write("; ");
    BinToDec(result);
}

double BinToDec(int[] arr)
{
    int i = 0;
    double sum = 0;
    while (i < arr.Length)
    {
        sum += arr[i] * Math.Pow(2, arr.Length - 1 - i);
        i++;
    }
    Console.Write(sum + " ");
    return sum;
}