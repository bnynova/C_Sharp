using System;

class CheckingPointInCircle
{
    static void Main()
    {
        double x;
        double y;
        double radius = 5;

        Console.Write("Enter x coordinate: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        y = Convert.ToDouble(Console.ReadLine());


        if ((x * x) + (y * y) <= radius * radius)
        {
       
            Console.WriteLine("The point is inside the circle");
        }
        else
        {
            Console.WriteLine("The point is not inside the circle");
        }

    }
}

