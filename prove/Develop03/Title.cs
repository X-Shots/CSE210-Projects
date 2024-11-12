public class Title
{
    private string name = "";

    public Title(int x, int y)
    {
        name = $"Alma 32 {x} - {y}";
    }

    public string  getName(){
        return name;
    }
   
}