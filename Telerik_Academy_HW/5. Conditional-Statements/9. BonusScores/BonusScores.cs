using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter number in the range [1..9]");
        sbyte userChoice = sbyte.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1: int firstsDigit1 = int.Parse(Console.ReadLine());
                Console.WriteLine(firstsDigit1 * 10);
                break;
            case 2: int firstsDigit2 = int.Parse(Console.ReadLine());
                Console.WriteLine(firstsDigit2 * 10);
                break;
            case 3: int firstsDigit3 = int.Parse(Console.ReadLine());
                Console.WriteLine(firstsDigit3 * 10);
                break;
            case 4: int secondDigit1 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit1 * 100);
                break;
            case 5: int secondDigit2 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit2 * 100);
                break;
            case 6: int secondDigit3 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit3 * 100);
                break;
            case 7: int secondDigit4 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit4 * 100);
                break;
            case 8: int secondDigit5 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit5 * 100);
                break;
            case 9: int secondDigit9 = int.Parse(Console.ReadLine());
                Console.WriteLine(secondDigit9 * 100);
                break;
            case 0:
                Console.WriteLine("Enter number between 1 - 3");
                break;
            default: Console.WriteLine("Enter number between 1 - 3");
                break;
        }
    }
}