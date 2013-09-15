using System;

class DeclaringSrtings2
{
    static void Main()
    {
        string withQuotedStrings = "The \"use\" of quotations causes difficulties.";
        string noQuotedStrings = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(withQuotedStrings);
        Console.WriteLine(noQuotedStrings);
        
    }
}

