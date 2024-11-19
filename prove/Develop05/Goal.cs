using System.Drawing;
using System.Dynamic;

public class Goal{
    private int points;
    private string name;
    private string description;
    private string isCompleated;


    public Goal(int points, string name, string description){
        this.points = points;
        this.name = name;
        this.description = description;
        isCompleated = "[ ]";
    }

    public string getName(){
        return name;
    }

    public string getDescription(){
        return description;
    }

    public string getIsCompleted(){
        return isCompleated;
    }

    public int getPointValue(){
        return points;
    }
    public virtual int getPoints(){
        if (isCompleated == "[ ]"){
            isCompleated = "[x]";
            return points;
        }
        else{
            return 0;
        }
        
    }
    public void complete(){
        isCompleated = "[x]";
    }

    public virtual string display(){
        return $"{isCompleated} {name} ({description})";
        
        
    }

    public virtual string save(){
        return $"goal~~{points}~~{name}~~{description}~~{isCompleated}~~";
    }

    


}