// See https://aka.ms/new-console-template for more information


// byte bt = 125; //2^8
// int i = 5; // 2^32 
// double d = 5.5; // 2^64
// string s = "hello"; // строковый тип данных
// bool b = false; //логические переменные 

// int a = 4;
// int x = 2022;
// double i2 = a/x;
// byte bt1 = (byte)x;
// int x1 = bt;
// Console.WriteLine(x1);

// Написать программу, которая на вход принимает число иивыводит его квадрат ( число умноженное на само себя).
// Например:
// // 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Hello");
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine()); // Convert помогает конвертировать строковый тип данных в численный 
//int num = 5;
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}"); // $ - это интерполяция помогает выводить значение переменных



