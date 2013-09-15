using System;

class CheckingBitsInPosition
{
    static void Main()
    {
        int p = 2;
        int n = 45;             
        int mask = 1 << p;    
        int nAndMask = n & mask; 
        int bit = nAndMask >> p;
        Console.WriteLine((bit) != 0 ? true : false);   //True

    }
}
