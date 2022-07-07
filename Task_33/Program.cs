// Task 33. Задайте массив, Напишите программу, которая определяет, 
// присутствует ли число в массиве.
// 4: массив [6,7,19,345,3] -> no.
// 3; массив [6,7,17,345,3] -> yes.
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[5];
var rnd = new Random();
int index = 0;
while (index < array.Length)
{
    array[index] = rnd.Next(0, 1000);
    Console.Write($"{array[index]} ");
    index++;
}
Console.WriteLine();

string CheckNumber(int[] arr, int num)
{
    string res = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) res = "Yes";  
    }
    return res;
}

string result = CheckNumber(array, number);
Console.WriteLine(result);


