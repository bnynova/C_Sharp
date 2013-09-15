using System;

class GCDTwoNumbersEuclideanAlgorithm
{
    public static int Euclid(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return Euclid(b, a % b);
    }

    public static void Main()
    {
        Console.WriteLine("Enter 2 numbers to find GCD");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int gcd = Euclid(n1, n2);
        Console.WriteLine("The GCD of {0}, {1} is ( {2} )", n1, n2, gcd);


    }
}