using System;

class CheckingDigistInInteger
{
        static void Main()
        {
            Console.Write("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n / 10;
            temp = temp / 10;
            temp = temp % 10;

            if (temp == 7)
            {
                Console.WriteLine("The third digit of the number  is 7");
            }
            else
            {
                Console.WriteLine("The third digit of the number  is not 7");
            }
            
        }
}

