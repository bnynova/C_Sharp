using System;

class CalculateFactorial
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        int k = int.Parse(Console.ReadLine());

        if ((n < 0) || (k <= 0))
        {
            Console.WriteLine("Enter x > 0 and k >= 0");
            return;
        }

        decimal sum = 1;
        decimal factoriel = 1;
        decimal factoriel1 = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                factoriel *= i;

                factoriel1 *= j;
                sum += (factoriel / factoriel1);
            }
        }
        Console.WriteLine(factoriel);
        Console.WriteLine(factoriel1);
        Console.WriteLine("Suma(n!)/(x^n)={0}", sum);
           
        
    }
}