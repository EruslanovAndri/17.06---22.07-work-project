// Задача 24: Напишите программу, которая принимает на
// вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= number; i++)
// {
//     sum += i;
//     if (i < number)Console.Write($"{i} + ");
//     else Console.Write($"{i} = ");
// }

// Console.WriteLine($"{sum}");

// Вариант преподавателя № 2

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

int Sum(int num)
{

    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;


    }
    return sum;
}

int sum = Sum(number);
int sum1 = Sum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
Console.WriteLine(sum1);