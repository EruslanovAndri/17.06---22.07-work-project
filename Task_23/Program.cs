﻿// Задача 23. Напишите программу, котороя на вход принимает число от 1 до N 
//и выдаёт значение кубов чисел.
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125



// Console.WriteLine(" Введите число ");
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine($" | Квадрат числа | {i} | = | {i * i, 2} | ");
// }


Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Куб числа | {i} | = | {i * i * i, 2} | ");
}