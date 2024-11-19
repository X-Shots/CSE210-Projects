using System;

class Program
{
    static void Main(string[] args)
    {
         
        Assignment one = new Assignment("Sam Smithy", "Intagrals");
        Console.WriteLine(one.GetSummary());

        
        MathAssignment two = new MathAssignment("Mike Ross", "Factoring", "8.4", "345-8975");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomeworkList());

        WritingAssignment three = new WritingAssignment("Eleanor Hall", "ART 101", "Colors in History");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}