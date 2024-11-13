public static class Display{
    private static Scripture scripture;

    public static void display(){
        if ( Welcome.getStartingVerse() == Welcome.getEndingVerse() ){
            scripture = new Scripture(Welcome.getStartingVerse());
        }
        else{
            scripture = new Scripture(Welcome.getStartingVerse(),Welcome.getEndingVerse());
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