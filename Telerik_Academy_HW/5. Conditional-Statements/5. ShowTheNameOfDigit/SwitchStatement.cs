﻿using System;

class SwitchStatement
{
    static void Main()
    {
        Console.Write("Enter a number less or equal than 12 : ");

        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            case 10:
                Console.WriteLine("Ten");
                break;
            case 11:
                Console.WriteLine("Eleven");
                break;
            case 12:
                Console.WriteLine("Twalve");
                break;
            default:
                Console.WriteLine("The number is bigger than 12");
                break;
        }
    }
}
