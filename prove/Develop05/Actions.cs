using System.Collections;
using System.Runtime.InteropServices.Marshalling;

public static class Actions{
    
    private static bool quit = false;
    private static Dictionary<string, Action> cases = new(){
        {"1", case1},
        {"2", case2},
        {"3", case3},
        {"4", case4},
        {"5", case5},
        {"6", case6}
    };

    private static Dictionary<string, Action> goalCreation = new(){
        {"1", SimpleGoal},
        {"2", EnternalGoal},
        {"3", ChecklistGoal}

    };

    public static bool ShoudlQuit(){
        return quit;
    }

    public static void runAction(string index){
        cases[index]();
    }

    private static void case1() {
        Console.WriteLine("\nThe types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.WriteLine("\nSelect a choice from the menu: ");
        string ans = Console.ReadLine();
        goalCreation[ans]();


    }

    private static void case2(){
        Console.WriteLine();
        Goals.display();
    }

    private static void case3(){
        Console.WriteLine();
        Console.WriteLine("What would you like to name the file? ");
        string file = Console.ReadLine();

        Goals.save(file);
    }

    private static void case4(){
        Console.WriteLine();
        Console.WriteLine("What is the name of the file you would like to laod? ");
        string file = Console.ReadLine();

        Goals.load(file);

    }

    private static void case5(){
        Console.WriteLine();
        Goals.display();
        Console.WriteLine("What is the number of the goal you completed? ");
        int index = Int32.Parse(Console.ReadLine());
        
        Goals.getPoints(index);
    }
    private static void case6(){
        quit = true;
    }



    private static void SimpleGoal(){
        Console.WriteLine("\n How many points is your goal worth? ");
        int points = Int32.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("\n What is a short discription of your goal? ");
        string description = Console.ReadLine();
        
        Goals.addGoal(points,name,description);
    }
    private static void EnternalGoal(){
        Console.WriteLine("\n How many points is your goal worth? ");
        int points = Int32.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("\n What is a short discription of your goal? ");
        string description = Console.ReadLine();

        Goals.addEternalGoal(points, name, description);
    }
    private static void ChecklistGoal(){
        Console.WriteLine("\n How many points is your goal worth? ");
        int points = Int32.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("\n What is a short discription of your goal? ");
        string description = Console.ReadLine();
        Console.WriteLine("\nHow many times should you do this goal?");
        int timesToComplete = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"\nHow many bonus points should you recive for doing this goal {timesToComplete} times? ");
        int bonus = Int32.Parse(Console.ReadLine());

        Goals.addCheckListGoal(points,name,description,bonus, timesToComplete);
    }



    
}