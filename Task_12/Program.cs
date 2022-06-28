// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// // что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

int num = new Random().Next(1000, 10000);
Console.WriteLine($"Number from interval up 10 to 100000 is the number {num}");
int didgit2 = 100;
int didgit3 = 1000;
int didgit4 = 10000;
int didgit5 = 100000;
int didgit6 = 1000000;
int didgit7 = 10000000;
int didgit8 = 100000000;
int didgit9 = 1000000000;


if (num < didgit2)
{
    Console.WriteLine("The number does not have the third didgit. Try one more time");
    Console.Write("");
}

else


// if (num < didgit3)
// {
//     int ThreeLengthNumber(int threeNum)


//     {
//         int firstDigit = threeNum / 100;
//         int secondDigit = threeNum % 10;
//         int result = secondDigit;
//         return result;

//     }

//     int res3 = ThreeLengthNumber(num);
//     Console.WriteLine($"The third didgit of the number is {res3}.");
//}
//if (num < didgit4)


{
    //int FourLengthNumber(int fourNum)

    // {



    //     int firstDigit = fourNum / 100;
    //     int secondDigit = fourNum / 10;
    //     int result = secondDigit % 10;
    //     return result;

    // }


    // int res4 = FourLengthNumber(num);
    // Console.WriteLine($"The third didgit of the number is {res4}.");
    //}
    ////if (num < didgit5)


    //{
        // int FiveLengthNumber(int fiveNum)

        // {



        // int firstDigit = fiveNum / 10;
        // int result = (firstDigit / 10) % 10;
        // return result;

        // }
     //   int res5 = FiveLengthNumber(num);
      //  Console.WriteLine($"The third didgit of the number is {res5}.");
    //}
    //int res5 = FiveLengthNumber(num);
    //     Console.WriteLine($"The third didgit of the number is {res}."); 
   // if (num < didgit6)

   // {
        // int SixNumber(int sixNumber)
        // {
        //     int firstDigit = sixNumber / 100;

        //     int result = (firstDigit / 10) % 10;
        //     return result;
        // }
        // int res6 = SixNumber(num);
        // Console.WriteLine($"The third didgit of the number is {res6}.");
   // }
    //int res6 = SixNumber(num);
    //     Console.WriteLine($"The third didgit of the number is {res6}."); 

    // if (num < didgit7)
    //{



        // int SevenNumber(int sevenNumber)
        // {
        //     int firstDigit = sevenNumber / 100;
        //     int result = (firstDigit / 100) % 10;
        //     return result;
        // }
        // int res7 = SevenNumber(num);
        // Console.WriteLine($"The third didgit of the number is {res7}.");
if (num < didgit8)
{
 int ThreeLengthNumber(num);
        {

            int firstDigit = threeNum / 100;
            int secondDigit = threeNum % 10;
            int result = secondDigit;
            return result;
        }
        int res3 = ThreeLengthNumber(num);
        Console.WriteLine($"The third didgit of the number is {res3}.");




        int FourLengthNumber(int fourNum)

        {
            int firstDigit = fourNum / 100;
            int secondDigit = fourNum / 10;
            int result = secondDigit % 10;
            return result;

        }

        int res4 = FourLengthNumber(num);
        Console.WriteLine($"The third didgit of the number is {res4}.");



        int FiveLengthNumber(int fiveNum);
        {
            int firstDigit = fiveNum / 10;
            int result = (firstDigit / 10) % 10;
            return result;
        }
        int res5 = FiveLengthNumber(num);
        
        {
            int firstDigit = eighthNumber / 100;
            int result = (firstDigit / 1000) % 10;
            return result;
        }
        //Console.WriteLine($"The third didgit of the number is {res5}.");
       // int EightNumber(int eighthNumber);

         int SixNumber(int sixNumber)
        {
            int firstDigit = sixNumber / 100;

            int result = (firstDigit / 10) % 10;
            return result;
        }
        //int res6 = SixNumber(num);
        //Console.WriteLine($"The third didgit of the number is {res6}.");

        int SevenNumber(int sevenNumber)
        {
            int firstDigit = sevenNumber / 100;
            int result = (firstDigit / 100) % 10;
            return result;
        }
        //int res7 = SevenNumber(num);
       // Console.WriteLine($"The third didgit of the number is {res7}.");

        


        
        //int res8 = EightNumber(num);
       // Console.WriteLine($"The third didgit of the number is {res8}.");

    else if  (num < didgit9)



        {
            int NineNumber(int nineNumber)
            {
                int firstDigit = nineNumber / 100;
                int result = (firstDigit / 10000) % 10;
                return result;
            }
        
            int res3 = ThreeLengthNumber(num);
            int res4 = FourLengthNumber(num);
            int res5 = FiveLengthNumber(num);
            int res6 = SixNumber(num);
            int res7 = SevenNumber(num);
            int res8 = EightNumber(num);
            int res9 = NineNumber(num);
            Console.WriteLine($"The third didgit of the number is {res9}.");
            Console.WriteLine($"The third didgit of the number is {res8}.");
            Console.WriteLine($"The third didgit of the number is {res7}.");
            Console.WriteLine($"The third didgit of the number is {res6}.");
            Console.WriteLine($"The third didgit of the number is {res5}.");
            Console.WriteLine($"The third didgit of the number is {res4}.");
            Console.WriteLine($"The third didgit of the number is {res3}.");

