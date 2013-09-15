using System;

class ReadingRadiusPrintingPerimeterCircle
{
    static void Main()
    {
        Console.Write("Enter the radius:");
        double radius = int.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
   
        Console.WriteLine("The perimeter of the circle is {0}", perimeter);
        Console.WriteLine("The area of the circle is {0}", area);
       
    }
}
