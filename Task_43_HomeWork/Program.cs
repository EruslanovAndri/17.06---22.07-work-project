// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите данные координаты k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные координату k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные координаты b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные координаты b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());


double GetPointOfIntersection(int kc1, int kc2, int bc1, int bc2)
{
    double res = Math.Sqrt(bc2 - bc1) / (kc1 - kc2);
    res = Math.Round(res, 2);
    double result = Math.Sqrt(kc1 * res + bc1);
    return result;
}
double result = GetPointOfIntersection(k1, k2, b1, b2);
Console.WriteLine(result);