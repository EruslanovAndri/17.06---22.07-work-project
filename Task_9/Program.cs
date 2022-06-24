// // 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int rndNum = new Random().Next (100,500);
// Console.WriteLine($"Случайное трех значное число {rndNum}");
// int firstDigit = rndNum / 100;
// int secondDigit = rndNum / 10;
// int thirdDigit = rndNum % 10;

// Console.Write(firstDigit);
// Console.Write(thirdDigit);

int rndNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное трех значное число {rndNum}");
int RemSecDigit(int num)
{
int firstDigit = num / 100;
int secondDigit = num % 10;
int result = firstDigit * 10 + secondDigit;
return result;
}
int res = RemSecDigit(rndNum);
Console.WriteLine(res);
