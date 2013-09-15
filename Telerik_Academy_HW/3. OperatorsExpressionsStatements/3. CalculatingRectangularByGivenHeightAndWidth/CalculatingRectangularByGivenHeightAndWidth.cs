using System;

class CalculatingRectangularByGivenHeightAndWidth
{
    static void Main()
    {
        double recWidth, recHeight;
        double recArea;

        Console.Write("Enter the height of rectangle:");
        recHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the widht of rectangle:");
        recWidth = Convert.ToDouble(Console.ReadLine());

        recArea = recHeight * recWidth;
        Console.WriteLine("The area of rectangle is: " + recArea);
    }
}
