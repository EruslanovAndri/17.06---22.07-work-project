//Задача 25:  Написать программу, которая принимает на вход два 
//числа (А и В) и выводит число А в натуральную степень В.

Console.Write("Введите первое число : ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число : ");
int num2 = int.Parse(Console.ReadLine());
int res = 1;

for (int i = 0; i < num2; i++)
{
    res *= num1;
}
Console.WriteLine($"Результат возведение числа {num1} в степень {num2} = {res}");

