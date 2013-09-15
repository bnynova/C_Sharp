using System;

class ExchangingIntValues
{
    static void SwapByRef(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int value1 = 5, value2 = 10;
        Console.WriteLine("value 1 = {0}", value1);
        Console.WriteLine("value 2 = {0}", value2);
        Console.WriteLine();
        Console.WriteLine("After exchanging their values are:");

        SwapByRef(ref value1, ref value2);

        Console.WriteLine("value 1 = {0}", value1);
        Console.WriteLine("value 2 = {0}", value2);

    }
}

