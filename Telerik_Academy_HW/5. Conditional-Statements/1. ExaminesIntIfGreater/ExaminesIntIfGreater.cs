using System;

class ExaminesIntIfGreater
{
    static void SwapByRef(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {

        Console.Write("First number: ");
        int fnumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int snumber = int.Parse(Console.ReadLine());

        if (fnumber > snumber)
        {
            Console.WriteLine("The first number value is = {0}", fnumber);
            Console.WriteLine("The second number value is = {0}", snumber);
            Console.WriteLine("Because the first value is greater than the second, we exchange their values:");

            SwapByRef(ref fnumber, ref snumber);

            Console.WriteLine("The first number value is = {0}", fnumber);
            Console.WriteLine("The second number value is = {0}", snumber);
        }
        else
        {
            Console.WriteLine("The first number value is = {0}", fnumber);
            Console.WriteLine("The second number value is = {0}", snumber);
        }
    }
}