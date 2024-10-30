using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int>();
        int ans = -1;
        Console.WriteLine("Enter a list of positive numbers, type 0 when finished.");
        
        while( ans != 0){
            Console.Write("Enter number: ");
            ans = int.Parse(Console.ReadLine());
            if(ans > 0){
                ints.Add(ans);
            }

        }

        int sum = 0;
        foreach (int x in ints){
            sum += x;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum / ints.Count()}");

        int max = -1;
        foreach(int x in ints){
            if( x > max){
                max = x;
            }
        }

        Console.WriteLine($"The largest number is: {max}");


        
        



    }
}