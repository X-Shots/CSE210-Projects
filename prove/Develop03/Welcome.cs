public static class Welcome{
    private static int startingVerse;
    private static int endingVerse;

    public static void welcome(){
        Console.Clear();
        Console.WriteLine("Welcome to scripture memoriziation!\nToday we will be studying Alma 32! Alma 32 is 43 verses long!");
        Console.WriteLine();
        Console.WriteLine("You will now select a range of verses. Please type the number of the starting verse.");
        startingVerse = Int32.Parse(Console.ReadLine());
        Console.WriteLine("PLease chose your last verse!");
        endingVerse = Int32.Parse(Console.ReadLine());
        validate();
    }

    public static int getStartingVerse(){
        return startingVerse;
    }

    public static int getEndingVerse(){
        return endingVerse;
    }

    private static void validate(){
        if (startingVerse > 43 || startingVerse < 1 || endingVerse > 43 || endingVerse < 1 || endingVerse < startingVerse){
            Console.WriteLine("\nYou have not chosen valid verses! Please remeber to pick from 1 to 43.\nThe ending verse must be equal to or greater than the starting verse.");
            Console.WriteLine();
            Console.WriteLine("Please type the number of the starting verse.");
             startingVerse = Int32.Parse(Console.ReadLine());
            Console.WriteLine("PLease chose your last verse!");
             endingVerse = Int32.Parse(Console.ReadLine());
        }
        
    }
}