using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number; ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        Console.WriteLine($"The average is: {average}");

        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        
        Console.WriteLine($"The largest number is: {max}");
    }    

}