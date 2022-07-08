// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string res = "";
while (num > 0)
{
    res = res + num % 2;
    num = num / 2;
}

string Reverse(string res)

{
    string newRes = "";
    for (int i = res.Length - 1; i >= 0; i--)
    {
        newRes = newRes + res[i];

    }
    return newRes;

}
string result = Reverse(res);
Console.WriteLine(result);