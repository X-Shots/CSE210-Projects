public static class Goals{
    private static List<Goal> goals = new();
    private static int totalScore = 0;

    public static int getScore(){
        return totalScore;
    }

    public static void addGoal(int points, string name, string description){
        goals.Add(new Goal(points,name,description));
    }
    public static void addEternalGoal(int points, string name, string description){
        goals.Add(new EternalGoal(points, name, description));
    }
    public static void addCheckListGoal(int points, string name, string description, int bonus, int timesToComplete){
        goals.Add(new CheckListGoal( points, name, description, bonus, timesToComplete ));
    }

    public static void display(){
        for( int i = 0; i < goals.Count(); i ++){
            Console.WriteLine($"{i + 1}. " + goals[i].display());
        }
    }

    public static void getPoints(int index){
        totalScore += goals[index - 1].getPoints();
    }

    public static void load(string file){
        List<Goal> tempGoals = new();
        string[] lines = System.IO.File.ReadAllLines($"{file}.txt");
        totalScore = Int32.Parse(lines[0]);
        for(int i = 1; i < lines.Count(); i++){
            string[] goalParts = lines[i].Split("~~");
            if(goalParts[0] == "goal"){
                tempGoals.Add(new Goal(Int32.Parse(goalParts[1]) ,goalParts[2],goalParts[3]));
            }
            else if (goalParts[0] == "eternal"){
                tempGoals.Add(new EternalGoal(Int32.Parse(goalParts[1]) ,goalParts[2],goalParts[3]));
            }
            else if (goalParts[0] == "checklist"){
                tempGoals.Add(new CheckListGoal( Int32.Parse(goalParts[1]) , goalParts[2], goalParts[3], Int32.Parse(goalParts[4]), Int32.Parse(goalParts[5]), Int32.Parse(goalParts[6])));
            }
        }
        goals = tempGoals;

    }

    public static void save(string file){
        using (StreamWriter outputFile = new StreamWriter($"{file}.txt")){
            outputFile.WriteLine($"{totalScore}");
            foreach(Goal goal in goals){
                outputFile.WriteLine(goal.save());
            }
        }
    }






    





}