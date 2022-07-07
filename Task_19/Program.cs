// Задача 19: Напишите программу, которая принимает 
//на вход пятизначное число и проверяет является ли это число палиндромом.
// 12821 - ДА.
// 14678 - НЕТ.
// 34743 - ДА.

Console.WriteLine("Is it Palindrom?");
Console.WriteLine();
Console.Write("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
int tempNumber = num;
int rem = 0;
int revNum = 0;
while (num > 0)
{
    rem = num % 10; 
    revNum = revNum * 10 + rem;
    num = num / 10;
}
if (revNum == tempNumber) Console.WriteLine($"Number {tempNumber} is Palindrom");
else Console.WriteLine($"Number {tempNumber} is not Palindrom");


























