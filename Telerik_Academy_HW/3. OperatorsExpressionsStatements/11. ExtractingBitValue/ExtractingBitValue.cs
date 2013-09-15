using System;

class ExtractingBitValue
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        int mask = 1 << i;
        int nAndMask = b & mask;
        int bit = nAndMask >> i;
        Console.WriteLine((bit) != 0 ? 1 : 0);

    }
}
