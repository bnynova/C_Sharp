using System;

class DeclarignStrings
{
    static void Main()
    {
        string varHello = "Hello ";
        string varWorld = "World";
        object varObj = varHello + varWorld;
        string varHW = varObj.ToString();

        Console.WriteLine(varHW);
    }
}

