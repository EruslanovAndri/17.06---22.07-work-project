// Программа , которая будет выдавать день недели по заданному номеру:
// 3 = среда
// 5 = пятница

Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num < 8)
{
    if (num == 1) Console.WriteLine("Monday");
    else if (num == 2) Console.WriteLine("Tuesday");
    else if (num == 3) Console.WriteLine("Wednesday");
    else if (num == 4) Console.WriteLine("Thirthday");
    else if (num == 5) Console.WriteLine("Friday");
    else if (num == 6) Console.WriteLine("Saturday");
    else if (num == 7) Console.WriteLine("Sunday");
    // else Console.WriteLine("Ошибка ввода");
}
else Console.WriteLine("Ошибка ввода");
