// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

int number; 
int remainder;
Console.WriteLine("Введите целое число");
number = Convert.ToInt32(Console.ReadLine());

remainder = number % 2; 

if(remainder == 0)
{
      Console.WriteLine("Число чётное.", number);
}
        
else 
{
      Console.WriteLine("Число не чётное.", number);
}
Console.WriteLine("Для завершения программы нажмите любую кнопку");
Console.ReadKey();
        
// Самостоятельно не смог решить данную задачу, обратился за помощью к google(;