public class EternalGoal : Goal {
   

    public EternalGoal(int points, string name, string description) : base(points, name, description){
        
    }

    public override int getPoints()
    {
        return base.getPointValue();
    }
    public override string save()
    {
        return $"eternal~~{base.getPointValue()}~~{base.getName()}~~{base.getDescription()}~~";
    }

    public override string display()
    {
        return base.display() + " (Eternal Goal)";
    }
}