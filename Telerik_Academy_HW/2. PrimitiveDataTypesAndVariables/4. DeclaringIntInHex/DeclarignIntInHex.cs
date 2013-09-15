using System;

class DeclarignIntInHex
{
    static void Main()
    {
        string decimalNumber = "254";
        int number = int.Parse(decimalNumber);
        string hex = number.ToString("X");

        Console.WriteLine(hex);
    }
}

