// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int finalResult = SumOfTheDidgit(num);
Console.WriteLine(finalResult);

int SumOfTheDidgit(int didgit)
{
    if (didgit > 0) 
    {
        return  didgit % 10 + SumOfTheDidgit(didgit / 10);  
    }
    return 0;
}
