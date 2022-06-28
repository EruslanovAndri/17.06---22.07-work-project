// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

int num = new Random().Next(10,3260000);
Console.WriteLine($"Number from interval up 10 to 100000 is the number {num}");
int didgit = 100;

while (num > didgit)
{
    num = num / 100;
    num = num + 1;
}

int ThirdN(int third)
{
    int firstNumber = num / 100;
    int secondNumber = num % 10;
    int result = secondNumber;
    return result;
}
int res = ThirdN(num);
Console.WriteLine($" The third didgit of the number is {res}");

// if (num < didgit)
//     {
//         Console.Write("The number does not have the third didgit");
//     }