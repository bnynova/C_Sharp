using System;

class CheckingBits
{
    static void Main()
    {
        int p = 3;
        int n;
        int mask = 1 << p;

        Console.Write("Enter a number:");

        n = (int)Convert.ToDouble(Console.ReadLine());

        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        Console.WriteLine(bit);

    }
}

