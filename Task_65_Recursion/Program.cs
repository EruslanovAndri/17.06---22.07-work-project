// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Введите число M:");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numN = int.Parse(Console.ReadLine());
NaturalNumber(numM, numN);

void NaturalNumber(int m, int n)
{
    if (n < m)
    {
        NaturalNumber(m, n + 1);
        Console.Write($"{n} ");
    }


    if (n > m)
    {
        NaturalNumber(m, n - 1);
        Console.Write($"{n} ");
    }

    if (n == m) Console.Write($"{n} ");
}
