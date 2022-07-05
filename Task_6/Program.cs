

// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Напишите любое число.");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int count = 0;
int res = 0;
int div = 2;

while( num > 0)
{
    num = num / div;
    count++;
}

