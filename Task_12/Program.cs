//Задача 13: Напишите программу, которая выводит третью цифру числа или сообщает ,
//что третьей цифры нет.
int num = new Random().Next(10, 214483648 );
Console.WriteLine($"The number from interval up 10 to 214483648 is the number {num}");
int div = 1000;
int tenDiv = 10;
int min = 100;
if (num < min)
{
Console.WriteLine("The number does not have third didgit");
}
while (num >= div)
{
num = num / tenDiv;
}
int ThirdN(int third)
{
int firstNumber = num / 100;
int secondNumber = num % 10;
int result = secondNumber;
return result;
}
int res = ThirdN(num);
Console.WriteLine($";The third didgit of the number is {res}");

/// Единственное , что я не могу понять, это как вывести сообщение на экран когда цифр в числе только две.
