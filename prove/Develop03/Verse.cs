public class Verse{
    Random rand = new Random();
    private int num;
    private int total;
    private int numSorted = 0;
    private string verse;
    private string[] sorted;

    public Verse(int num, string verse){
        this.num = num;
        this.verse = verse;
        sorted = this.verse.Split(" ");
        for (int i = 0; i < sorted.Count() - 1; i++){
            sorted[i] = sorted[i] + " ";
        }
        total = sorted.Count();

    }
    public Verse(){
    }

    public string[] getSorted(){
        return sorted;
    }

    public void scramble(){
        
        int count = 0;
        int wordsToChange = rand.Next(1,4);
        while(count < wordsToChange && numSorted < total){
            int x = rand.Next(0, sorted.Count());
            if (sorted[x] != "___ "){
                sorted[x] = "___ ";
                count++;
                numSorted++;
            }

        }

    }

    public void display(){
        Console.WriteLine();
        Console.Write($"{num} ");
        for(int i = 0; i < sorted.Count(); i++){
            if( i % 8 == 0 && i > 0) {
                Console.WriteLine(sorted[i]);
            }
            else{
                Console.Write(sorted[i]);
            }
        }



    }

    public bool isDone(){
        return numSorted >= total;
    }

}