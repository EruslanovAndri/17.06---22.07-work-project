// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

int num1 = new Random().Next(10, 100);
Console.WriteLine($"Number from interval up 10 to 10000 is the number {num1}");
int didgit = 100;

int thirdDigit(int num)

{
    if (num1 < didgit) Console.WriteLine("The didgit does not have the third didgit. Try one more time");
    else Console.Write("");
    break;

    int firstDigit = num1 / 100;
    int secondDigit = num1 / 10;
    int thirdDigit = num1 % 10;
    int fourDidgit = num1 % 10;
    int fiveDidgit = num1 % 10;
    int result = secondDigit % 10;
    return result;
}

int res = thirdDigit(num1);
Console.WriteLine($"The third didgit of the number is {res}.");








