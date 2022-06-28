 //17 Напишите программу, которая  на вход координаты точек ( X Y),
 //причем X не равен 0 и Y не равен 0 и выдает номер четверти прлоскости , 
//в которой находится эта точка. 


Console.WriteLine("Введите координаты точки X и Y");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// 1 . Обычный путь решения!!!
//  if (x > 0 && y > 0)
//  {
//     Console.WriteLine("Первая четветрть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else Console.WriteLine("Введены некорректные координаты");

// 2. Путь решения через метод.

string Quard(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}
string result = Quard(x, y);
Console.WriteLine(result);
