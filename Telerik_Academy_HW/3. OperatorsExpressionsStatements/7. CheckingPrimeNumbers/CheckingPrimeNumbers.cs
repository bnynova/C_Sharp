using System;

class CheckingPrimeNumbers
{
    static void Main()
    {
        int tmp;
        int i;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number < 100)
        {
            for (i = 2; i < number; i++)
            {
                tmp = number % i;
                if (tmp == 0)
                {
                    break;
                }
            }
            if (i == number)
            {
                Console.WriteLine("The number is a prime.");
            }
            else
            {
                Console.WriteLine("The number is not a prime.");
            }
        }
        else Console.WriteLine("Enter a number less than 100.");
    }
}