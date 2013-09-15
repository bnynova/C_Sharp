using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.Write("Enter a nuber: ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        int number = 1;


        Console.Write("The numbers from 1 to {0} are: {1},",n,  number);
        while (number < n)
        {
            number++;
            
            Console.Write("{0},", number);
        }
    }
}