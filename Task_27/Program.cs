// Задача 25: Написать программу , 
// которая принимает на вход число и выдает сумму цифр в цисле.

Console.WriteLine("Введите любое целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;
int count = 0;

while (number > 0)
{
    
    res = res + number % 10;
    number = number / 10;
    count++;
}

Console.WriteLine($"{res}");




