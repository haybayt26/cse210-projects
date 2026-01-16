using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int largest = 0;
        bool play = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (play == true)
        {
            Console.Write("Enter number: ");
            string entryStr = Console.ReadLine();
            int entryInt = int.Parse(entryStr);
            numbers.Add(entryInt); 

            if (entryInt > largest)
            {
                largest = entryInt;
            }
            if (entryInt == 0)
            {
                play = false;
            }
        }

        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");
    }
}