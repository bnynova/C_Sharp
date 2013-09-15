using System;

class  NumbersNotDivisibleThreeSeven
{
    static void Main()
    {
        Console.Write("Enter a nuber: ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        
        Console.Write("The numbers not divisible by 3 and 7 are: ");
        for (int i = 1; i < n; i++)
        {
            
            if (i%3 != 0 && i%7 != 0)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}