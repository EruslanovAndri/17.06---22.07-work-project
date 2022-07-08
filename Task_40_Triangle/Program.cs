
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите размер первой стороны треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер второй стороны треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер третьей стороны треугольника");
int c = Convert.ToInt32(Console.ReadLine());

// if (a < b + c && b < a + c && c < a + b)
// {
//     Console.WriteLine($"Yes");
// }
// else Console.WriteLine($"No");

bool Triangle(int ad, int bd, int cd)
{
    return ad < bd + cd && bd < ad + cd && cd < ad + bd;
}
bool res = Triangle(a,b,c);
Console.Write(res ? "Yes" : "No");