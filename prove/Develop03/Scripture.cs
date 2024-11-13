using System.Security.Cryptography.X509Certificates;

public class Scripture{
    // chsnge nsme to verses
    private static List<Verse> scripture = new List<Verse>();
    
    
    private string title;

    private int first;
    private int last;

    public Scripture(){

     }
    public Scripture(int x, int y){
        first = x;
        last = y;
        string[] lines = System.IO.File.ReadAllLines("Alma32.txt");
        for(int i = x - 1; i < y; i++){
            string[] split = lines[i].Split("*");
            scripture.Add(new Verse(Int32.Parse(split[0]),split[1]));
        }
        title = $"Alma 32: {x} - {y}";

        
    }

    public Scripture(int x){
        first = x;
        
        string[] lines = System.IO.File.ReadAllLines("Alma32.txt");
        
            string[] split = lines[x - 1].Split("*");
            scripture.Add(new Verse(Int32.Parse(split[0]),split[1]));
        
        title = $"Alma 32: {x}";
    }
    
    public int getFirst(){
        return first;
    }

    public int getLast(){
        return last;
    }
    
    
    

    

    public void display(){
        Console.WriteLine();
        Console.WriteLine(title);
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