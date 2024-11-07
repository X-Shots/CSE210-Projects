    
using System.IO;
    
public class Journal{
   Random rand = new Random();
    public List<string> prompts = ["What is the worst thing that has happend to you today? ", "Is there something exiting coming up? ", "If you could have one food item delivered to you right now what would it be?", "Did you pray today? If so, how did it go?", "What are you going to do to achive your 1, 5, and 10 year goals?"];
    public List<Entry> entries = new List<Entry>();
     
    private Entry currentEntry;

    private int totalEntries;


    public void getEntry(){
        currentEntry = new Entry(prompts[rand.Next(prompts.Count())]);
        entries.Add(currentEntry);
        string[] nums = System.IO.File.ReadAllLines("entries.txt");
        totalEntries = Int32.Parse(nums[0]) + 1;
        nums[0] = (totalEntries).ToString();
        File.WriteAllLines("entries.txt", nums);
         
    }

    public void display(){
        foreach(Entry e in entries){
            Console.WriteLine(e.display());
            Console.WriteLine();
        }
        Console.WriteLine($"Total entries: {totalEntries}");
    }
    
    public void saveToFile(string filename){
        using (StreamWriter outputFile = new StreamWriter($"{filename}.txt")){
            foreach(Entry e in entries){
                outputFile.WriteLine(e.Load());
            }
        }

    }

    public void loadFile(string filename){
        entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

        foreach (string i in lines){
            string [] parts = i.Split(",");
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            entries.Add(entry);
        }
        Console.Write(lines);
        



    }
}


    

    

    







