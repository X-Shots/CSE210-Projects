using System;
// I sowed creativity by allowing the user to slect a range of verse from Alma 32 to memorize.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Console.Clear();

        
        Console.WriteLine("Welcome to scripture memoriziation!");
        Console.WriteLine("Today we will be studying Alma 32! Alma 32 is 43 verses long!");
        Console.WriteLine();
        Console.WriteLine("You will now select a range of verses. Please type the number of the starting verse.");
        int x = Int32.Parse(Console.ReadLine());
        while(x > 43 || x < 0){
            Console.WriteLine($"{x} is not a verse in Alma 32!\nPlease pick a number 1 - 43");
            x = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("PLease chose your last verse!");
        int y = Int32.Parse(Console.ReadLine());
        while(y < x || y > 43 || y < 0){
            if ( y < x ){
                Console.WriteLine("Your last verse must be equal to or greater than your first verse!\nPlease chose a new verse ");
                y = Int32.Parse(Console.ReadLine());
            }
            else{
                Console.WriteLine($"{y} is not a verse in Alma 32!\nPlease pick a number 1 - 43");
                y = Int32.Parse(Console.ReadLine());

            }
        }
        if ( x == y ){
             scripture = new Scripture(x);
        }
        else{
             scripture = new Scripture(x,y);
        }
        
        

        string ans = "";
        scripture.display();
        while(ans != "quit" && !scripture.isDone()){
            Console.Clear();
            scripture.display();
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type 'quit' to quit.");
            
            ans = Console.ReadLine();
            if(ans != "quit"){
                scripture.scramble();
                
            }
            
        }
        Console.Clear();
        scripture.display();




        
    

    }
}