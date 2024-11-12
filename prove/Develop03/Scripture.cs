using System.Security.Cryptography.X509Certificates;

public class Scripture{
    private static List<Verse> scripture = new List<Verse>();
    private Verse thisVerse = new Verse();
    
    private Title title;

    private int first;
    private int last;

    public Scripture(int x, int y){
        first = x;
        last = y;
        string[] lines = System.IO.File.ReadAllLines("Alma32.txt");
        for(int i = x - 1; i < y; i++){
            string[] split = lines[i].Split("*");
            scripture.Add(new Verse(Int32.Parse(split[0]),split[1]));
        }
        title = new Title(x,y);

        
    }
    
    public int getFirst(){
        return first;
    }

    public int getLast(){
        return last;
    }
    
    
    

    

    public void display(){
        Console.WriteLine();
        Console.WriteLine(title.getName());
        foreach(Verse v in scripture){
            v.display();
            Console.WriteLine();
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