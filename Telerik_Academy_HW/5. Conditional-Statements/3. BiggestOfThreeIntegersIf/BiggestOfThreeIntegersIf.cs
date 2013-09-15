using System;

class BiggestOfThreeIntegersIf
{
    static void Main()
    {

        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest integer is {0}", firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest integer is {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest integer is {0}", thirdNumber);
        }
    }
}
    