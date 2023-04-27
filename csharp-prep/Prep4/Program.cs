using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);
        }

        int sum = numbers.Sum();
        float average = sum / (numbers.Count - 1);
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}