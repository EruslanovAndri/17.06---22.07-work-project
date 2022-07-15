// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Программа определяет количество чисел больше нуля введенных пользователем.");
Console.WriteLine();
Console.Write("Введите количество чисел: ");
Console.WriteLine();
Console.Write("Введите числа: ");
int countNumber = int.Parse(Console.ReadLine());

void GetAmountNumbersAboveZero(int countNumber)
{
    int number = countNumber;
    int count = 0;
    for (int i = 0; i < countNumber; i++)
    {
        number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
}

GetAmountNumbersAboveZero(countNumber);
Console.WriteLine($"Количество чисел больше нуля = {countNumber}");

// Work.