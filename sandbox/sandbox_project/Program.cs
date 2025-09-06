using System;
using System.Diagnostics;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    { }
    //  void MultiplesOf(double number, int length)
    //  {
    //      // TODO Problem 1 Start
    //      // Remember: Using comments in your program, write down your process for solving this problem
    //      // step by step before you write the code. The plan should be clear enough that it could
    //      // be implemented by another person.
    //      // ------------IMPLEMENTATION-----------
    //      // To solve this problem, I first initialized a variable 'i' in a 'for' loop that runs while the 
    //      // variable 'i' is less than the product of number of multiples(length) we want to get
    //      // and the start number(number) and then increment the variable 'i'  by the start number.
    //      for (double i = number; i <= length * number; i += number)
    // 
    //      Console.WriteLine(i);
    //      // string ranton = Console.ReadLine();
    //     // return i; // replace this return statement with your own
    //  }
    //  MultiplesOf(6, 7);
    public double[] Of(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // ------------IMPLEMENTATION-----------
        // To solve this problem, I first initialized a variable 'i' in a 'for' loop that runs while the 
        // variable 'i' is less than the product of number of multiples(length) we want to get
        // and the start number(number) and then increment the variable 'i'  by the start number.

        // Create an array to hold the multiples
        double[] multiples = new double[length];

        for (int i = 0; i <= length; i++)
        {
            multiples[i] = (i + 1) * number; // Calculate each multiple
        }

        return multiples; // Return the array of multiples
        
    }
     
}
        
    
    

