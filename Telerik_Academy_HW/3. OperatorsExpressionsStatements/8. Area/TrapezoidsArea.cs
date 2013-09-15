using System;

class TrapezoidsArea
{
    static void Main()
    {
        
        double side1;
        double side2;
        double height;

        Console.Write("Enter side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height: ");
        height = Convert.ToDouble(Console.ReadLine());


        double areaOfTrapezoid = (side1 + side2) / 2 * height;

        Console.WriteLine("The area is {0}", areaOfTrapezoid);
    }
}
