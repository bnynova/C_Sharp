using System;

class MyAgeAfterTenYears
{
    static void Main()
    {
       
        int myAge, ageAfterTenYears;

        Console.Write("My age is:  ");
        string strShirts = Console.ReadLine();
        myAge = int.Parse(strShirts);

        ageAfterTenYears = myAge + 10;
        Console.WriteLine("After 10 years my age will be {0}",ageAfterTenYears);
      
    }
}
