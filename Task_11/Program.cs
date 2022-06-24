// // Задача № 10 Напишите программу,которая принимает 
// //на вход трёхзначное число и на выходе показывает вторую чифру числа.

int rndNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число из диапазона от 100  до 999: {rndNum}");

int ShowSecDigit(int num)
{
    int firstNumber = num / 100;
    int secondNumber = num / 10;
    //int thirdDigit = num % 10;
    int result = secondNumber % 10;
    return result;
}
int res = ShowSecDigit(rndNum);
Console.WriteLine($"Среднее число из трёхзначного = {res}"); // Ура!!! У меня получилось)





