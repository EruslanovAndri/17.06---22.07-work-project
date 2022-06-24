// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = 78;
Console.WriteLine(num);
int didgit = 456;
int thirdDigit(int num)

//if (num < didgit)
{ 
    if (num < didgit);
    int firstNumber = num / 100;
    int secondNumber = num / 10;
    int thirdDigit = num % 10;
    int result = thirdDigit % 10;
    return result;
    //int res = thirdDigit(num);
    //Console.WriteLine($"Третья цифра заданного числа = {res} ");
}
     int res = thirdDigit(num);
     Console.WriteLine($"Третья цифра заданного числа = {res} ");
//     else
// {
//     //int res = thirdDigit(didgit);
//     //Console.WriteLine($"Третьего числа нет = {num} ");
// }