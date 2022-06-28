// 22. Напишите программу , которая принимает 
//число N и на выходе выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25.
// 2 -> 1,4.

// 1 решение в группе и оно работает.
// Console.WriteLine("Программа выводящая квадрат чисел от 1 до N");
// Console.WriteLine("Введите любое целое чило .");
// int num = Convert.ToInt32(Console.ReadLine());

// void GetQuad(int a)
// {
//     int index = 1;
//     while (index <= a)
//     {
//         int quad = index * index;
//         Console.Write($" {quad} ");
//         index++;
//     }
// }
//  GetQuad(num);

// 2. решение преподавателя.

Console.WriteLine(" Введите число ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($" | Квадрат числа | {i} | = | {i * i, 2} | ");
}

