using System;

class SortRealValuesDescendingOrder
{
    static void Main()
    {

        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && thirdNumber < firstNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        if (thirdNumber >= secondNumber && firstNumber <= thirdNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        if (secondNumber > firstNumber && thirdNumber < secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
    }
}
