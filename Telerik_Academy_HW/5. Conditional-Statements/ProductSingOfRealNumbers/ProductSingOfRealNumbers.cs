using System;

class ProductSingOfRealNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of the three numbers is: 0");
        }
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is negative");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is positive");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is positive");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is positive");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is negative");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is negative");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is negative");
        }
        else
        {
            Console.WriteLine("The sign of the product is positive");
        }
    }
}