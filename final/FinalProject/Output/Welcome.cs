public static class Welcome{
    public static void welcome(){
        Console.Clear();
        Console.WriteLine("Welcome to Virtual Car Shopping!");
        Console.WriteLine("\nVirtual Car Shopping is equipped with multiple tools to aid your car shopping experience!");
        
    }
    public static void options(){
        Console.WriteLine("Here are the experiences avalible: ");
        Console.WriteLine();
        Console.WriteLine("\tBrowse: Look at random cars in detail until you have seen every car!");
        Console.WriteLine("\tPlan: Enter some basic savings details and we will show you some cars you could buy in tte future");
        Console.WriteLine("\tList: List all avaliable cars in a simple text format!");
        Console.WriteLine("\tFilter: Filter through cars by attributes like type, price, and manufacturer!");
        Console.WriteLine("\tDisplay: Display details about a car with an image");
        Console.WriteLine();
    }
}