using System;

class CoefficientsOfQuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0.0)
        {
            Console.WriteLine("Enter a number < or > then 0");
        }
        else
        {
            double disc = ((b * b) - (4 * a * c));
            if (disc < 0)
            {
                Console.WriteLine("The quadratic equation has no real roots.");
            }
            else if (disc > 0)
            {
                double firstRoot = ((-b) + (Math.Sqrt(disc))) / (2 * a);
                double secondRoot = ((-b) - (Math.Sqrt(disc))) / (2 * a);
                Console.WriteLine("The first root of the quadratic equation is: " + firstRoot);
                Console.WriteLine("The second root of the quadratic equation is: " + secondRoot);
            }
            else
            {
                double onlyRoot = ((-b) / (2 * a));
                Console.WriteLine("The only root of the quadratic equation is: " + onlyRoot);
            }
        }       
    }
}
