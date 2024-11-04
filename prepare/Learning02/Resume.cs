public class Resume{
    public string name;
    public List<Job> jobs = new List<Job>();

    public void display(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job x in jobs)
        {
            x.display();
        }
    }


}