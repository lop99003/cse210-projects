using System;

class Program
{
    static void Main(string[] args)
    {
       //STEP 4 Constructor that has no parameters that initializes the number to 1/1.
       Fraction f1 = new Fraction();
       Console.WriteLine(f1.GetFractionString()); // Output 1/1
       Console.WriteLine(f1.GetDecimalValue()); // Output 1

       //Constructor that has one parameter for the top and that initializes the 
       //denominator to 1. So that if you pass in the number 5, the fraction would be 
       //initialized to 5/1.
       Fraction f2 = new Fraction(5);
       Console.WriteLine(f2.GetFractionString()); // STEP 5 Output 5/1
       Console.WriteLine(f2.GetDecimalValue()); // Output: 5

       //Constructor that has two parameters, one for the top and one for the bottom. 3/4
       Fraction f3 = new Fraction(3, 4);
       Console.WriteLine(f3.GetFractionString()); //STEP 5 Output 3/4
       Console.WriteLine(f3.GetDecimalValue()); //STEP 5 Output 0.75

       //Constructor that has two parameters, one for the top and one for the bottom. 1/3
       Fraction
       f4 = new Fraction(1, 3);
       Console.WriteLine(f4.GetFractionString()); // STEP 5 Output 1/3
       Console.WriteLine(f4.GetDecimalValue()); // STEP 5 Output 0.3333333
    }
}