 public class Job{
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public void display(){
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }



}