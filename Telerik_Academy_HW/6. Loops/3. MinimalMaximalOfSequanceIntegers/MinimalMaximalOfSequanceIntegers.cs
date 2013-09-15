using System;

class MinimalMaximalOfSequanceIntegers
{
    static void Main()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int n;
        bool trueN;
        int number;
        bool trueNum;
        do
        {
            Console.WriteLine("Enter a number: ");
            string str = Console.ReadLine();
            trueN = int.TryParse(str, out n);
            if (!trueN || !(n != 0))
            {
                Console.WriteLine("Enter a number !0");
            }
        } while (!trueN || !(n != 0));
        Console.WriteLine("Enter sequence of N numbers : ");
        for (int i = 1; i <= n; i++)
        {
            do
            {
                Console.Write("", i);
                string str = Console.ReadLine();
                trueNum = int.TryParse(str, out number);
                if (!trueNum)
                {
                    Console.WriteLine("Invalid number !");
                }
            } while (!trueNum);
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        if (min == max)
        {
            Console.WriteLine("All numbers are equal");
        }
        else
        {
            Console.WriteLine("The maximal is: {0}\nThe minimal is: {1}", max, min);
        }
    }
}