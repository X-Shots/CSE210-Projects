public class Title
{
    private string name = "";

    public Title(int x, int y)
    {
        name = $"Alma 32: {x} - {y}";
    }

    public Title(int x){
        name = $"Alma 32: {x}";
    }

    public string  getName(){
        return name;
    }
   
}