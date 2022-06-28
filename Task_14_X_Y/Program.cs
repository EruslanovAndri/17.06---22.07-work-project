// // Напишите программу, которая  на вход координаты точек ( X Y),
// // причем X не равен 0 и Y не равен 0 и выдает номер четверти прлоскости , 
// //в которой находится эта точка. 


// Console.WriteLine("Введите координаты точки X и Y");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());


// // if (x > 0 && y > 0)
// // {
// //     Console.WriteLine("Первая четветрть");
// // }
// // else if (x < 0 && y > 0)
// // {
// //     Console.WriteLine("Вторая четверть");
// // }
// // else if (x < 0 && y < 0)
// // {
// //     Console.WriteLine("Третья четверть");
// // }
// // else if (x > 0 && y < 0)
// // {
// //     Console.WriteLine("Четвертая четверть");
// // }
// // else Console.WriteLine("Введены некорректные координаты");

// string Quard(int xc, int yc)
// {
//     if (xc > 0 && yc > 0) return "Первая четверть";
//     if (xc < 0 && yc > 0) return "Вторая четверть";
//     if (xc < 0 && yc < 0) return "Третья четверть";
//     if (xc > 0 && yc < 0) return "Четвертая четверть";
//     return "Введены некорректные координаты";
// }
// string result = Quard(x, y);
// Console.WriteLine(result);



// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
string result;
string Quard(int a)
{
    string res = "";
    if (a == 1) res = "x>0 и y >0";
    if (a == 2) res = "x<0 и y >0";
    if (a == 3) res = "x<0 и y <0";
    if (a == 4) res = "x>0 и y <0";
    return res;
}
if (num > 0 && num < 5)
{
    result = Quard(num);
}
else 
{
    result = "Некорректный ввод";
}
Console.WriteLine(res); //!!!!!!!!!!!! Не работает

// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

// Console.WriteLine("Введите данные координаты x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите данные координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите данные координаты x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите данные координаты y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());


// double Distance(int a1, int b1, int a2, int b2)
// {
//     double res = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2));
//     res = Math.Round(res, 2);
//     return res;
// }
// double result = Distance(x1, y1, x2, y2);
// Console.WriteLine(result);
