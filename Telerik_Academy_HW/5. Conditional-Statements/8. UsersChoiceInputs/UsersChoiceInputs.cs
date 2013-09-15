using System;

class UsersChoiceInputs
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double, and 3 for string");
        sbyte userChoice = sbyte.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1: int intCohise = int.Parse(Console.ReadLine());
                Console.WriteLine(intCohise + 1);
                break;
            case 2: double doubleCohise = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleCohise + 1);
                break;
            case 3: string stringCohise = Console.ReadLine();
                Console.WriteLine(stringCohise + "*");
                break;
            default: Console.WriteLine("Enter number between 1 - 3");
                break;
        }
    }
}