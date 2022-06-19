
// Написать программу , которая на 
// вход принимает два числа и проверяет , является ли первое число квадратом.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)

{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}