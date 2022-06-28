
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

Console.Write(result);