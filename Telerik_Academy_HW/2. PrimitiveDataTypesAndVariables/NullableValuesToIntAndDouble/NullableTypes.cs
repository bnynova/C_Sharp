using System;

class NullableTypes
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;

        Console.WriteLine("The int? value \" {0}\"", nullableInt);
        Console.WriteLine("The double? value \" {0}\"", nullableDouble);
    }
}
