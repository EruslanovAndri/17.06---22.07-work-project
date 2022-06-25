// Задача 15: Напишите программу, 
//которая принимает на вход цифру,обозначающую день недели , 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите цифру интересующего дня недели.");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 0 && num < 8)
{
    if (num == 1) Console.WriteLine("День не выходной.");
    else if (num == 2) Console.WriteLine("День не выходной.");
    else if (num == 3) Console.WriteLine("День не выходной.");
    else if (num == 4) Console.WriteLine("День не выходной.");
    else if (num == 5) Console.WriteLine("День не выходной.");
    else if (num == 6) Console.WriteLine("День выходной.");
    else if (num == 7) Console.WriteLine("День выходной.");
}
else Console.WriteLine("Такого дня недели не существует.");





