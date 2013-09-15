using System;

class CompressingFloatingPoint
{
    static void Main()
    {
        double value1 = 3.10f;
        double value2 = 1.056f;
        double firstSumValues = 4.156f;
        
        Console.WriteLine(value1);
        Console.WriteLine(value2);

        Console.WriteLine("The sum of the first two numbers is {0}", firstSumValues);
        Console.WriteLine("The calculation of the first two numbers is {0}", value1+value2);

        Console.WriteLine("----------------------------");

        decimal value3 = 1.00100056m;
        decimal value4 = 0.00005622m;
        decimal secondSumValues = 1.00105678m;

        Console.WriteLine(value3);
        Console.WriteLine(value4);

        Console.WriteLine("The sum of the second two numbers is {0}", secondSumValues);
        Console.WriteLine("The calculation of the first two numbers is {0}", value3 + value4);

    }
}

