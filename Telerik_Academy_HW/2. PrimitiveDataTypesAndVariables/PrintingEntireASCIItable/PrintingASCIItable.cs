using System;
using System.Collections.Generic;
using System.Text;

class PrintingASCIItable
{
    static void Main()
    {
        for (byte counter = 0; counter < 255; counter++)
        {
            Console.WriteLine(" " + (char)counter);
        }
    }
}
