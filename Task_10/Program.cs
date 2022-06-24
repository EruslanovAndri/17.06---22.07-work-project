// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Решение в группах задач:
// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 / num2;

if (res == 0)
{
    Console.WriteLine($"Кратно");
}
else 
{
    Console.WriteLine($"Не кратно, отсаток от деления: {res}");
}

 




// int MultipleDigit (int a, int b)

// {
//    int  remainder = 0;
//    int result;
//    if (a / b) - b == remainder;
//    return result;

// }

// int RemSecDigit(int num)
// {
// int firstDigit = num / 100;
// int secondDigit = num % 10;
// int result = firstDigit * 10 + secondDigit;
// return result;
// }
// int res = RemSecDigit(rndNum);
// Console.WriteLine(res);