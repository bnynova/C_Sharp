using System;

class BooleanExpressionCheckingInteger
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool devNumber = number % 5 == 0 && number % 7 == 0;
        if (devNumber)
        {
            Console.WriteLine("The number {0} can be devided by 5 and 7 ", number);
        }
        else
        {
            Console.WriteLine("The number {0} can not be devided by 5 and 7 ", number);
        }
    }
}
