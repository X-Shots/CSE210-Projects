public class Scripture{
    private static List<Verse> scripture = new List<Verse>();
    private Verse thisVerse = new Verse();
    private string title;

    public Scripture(int x, int y){
        string[] lines = System.IO.File.ReadAllLines("Alma32.txt");
        for(int i = x - 1; i < y; i++){
            string[] split = lines[i].Split("*");
            scripture.Add(new Verse(Int32.Parse(split[0]),split[1]));
        }
        title = $"Alma 32 {x} - {y}";
    }
    

    

    public void display(){
        Console.WriteLine();
        Console.WriteLine(title);
        foreach(Verse v in scripture){
            v.display();
        }
    }

    public void scramble(){
        
        foreach(Verse v in scripture){
            v.scramble();
           // v.display();
            
            
        }
    }

    public bool isDone(){
        bool boo = true;
        foreach(Verse v in scripture){
            if(!v.isDone()){
                boo = false;
            }
        }
        return boo;
    }



    
}