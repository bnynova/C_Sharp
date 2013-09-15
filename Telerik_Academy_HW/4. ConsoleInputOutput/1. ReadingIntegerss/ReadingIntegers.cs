using System;

class ReadingIntegers
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, sum);

    }
}
