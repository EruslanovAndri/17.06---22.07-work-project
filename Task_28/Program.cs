
// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int Multi(int num1);
// {
//     int multipull = 1;
//     for (int i = 1; i < num1; i++)
//     {
//         multipull = multipull * i;
//     }
//     return multipull;
// }
// int multipull=Multi(num);
// Console.WriteLine($"произведение чисел от 1 до {num} = {multipull}");

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int res = 1;
int start =1;

while(start <= num)
{
    checked
    {
        res *= start;
        start++;
    }
}

Console.WriteLine(res);




