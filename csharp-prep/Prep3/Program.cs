using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //int num = int.Parse(Console.ReadLine());
        Random random = new Random();
        int num = random.Next(1,100);
        
        int guess = -1;
        while(guess != num){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > num){
                Console.WriteLine("Lower");
            }
            else if (guess < num){
                Console.WriteLine("Higher");
            
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }
        

    }
}