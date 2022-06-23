// Напишите программу , 
// которая на вход принимает два числа и выдает , 
// какое число большее, акакое меньшее.



Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());





if (a > b)  
{
     Console.WriteLine($"Первое число больше второго {a} ");
   
} 
else 
{
     Console.WriteLine($"Второе число больше первого {b} "); 
     
}


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine()); // Convert помогает конвертировать строковый тип данных в численный 
// //int num = 5;
// int square = num * num;
// Console.WriteLine($"Квадрат числа {num} = {square}"); // $ - это интерполяция помогает выводить значение переменных