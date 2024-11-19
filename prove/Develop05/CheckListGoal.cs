public class CheckListGoal : Goal{
    private int bonus;
    private int timesToComplete;
    private int timesCompleted;

    public CheckListGoal(int points, string name, string description, int bonus, int timesToComplete) : base(points, name, description){
        this.bonus = bonus;
        this.timesToComplete = timesToComplete;
        timesCompleted = 0;
    }
    public CheckListGoal(int points, string name, string description, int bonus, int timesCompleted, int timesToComplete) : base(points, name, description){
        this.bonus = bonus;
        this.timesToComplete = timesToComplete;
        this.timesCompleted = timesCompleted;
        if (timesCompleted > timesToComplete){
            base.complete();
        }
    }

    public void setTimesCompleted(int timesCompleted){
        this.timesCompleted = timesCompleted;
    }

    public override int getPoints()
    {
        timesCompleted ++;
        if (timesCompleted < timesToComplete){
            
            return base.getPointValue();
        }
        else if (timesCompleted == timesToComplete){
            base.complete();
            return base.getPointValue() + bonus;
        }
        else{
            return 0;
        }
    
        
        
    }

    public override string display()
    {
        return base.display() + $"-- Has been completed {timesCompleted}/{timesToComplete} times.";
    }

    public override string save()
    {
        return $"checklist~~{base.getPointValue()}~~{base.getName()}~~{base.getDescription()}~~{bonus}~~{timesCompleted}~~{timesToComplete}~~";
    }


}