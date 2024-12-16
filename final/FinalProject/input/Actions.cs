using System.IO.Compression;

public static class Actions{
    public static void action(string ans){
        Console.WriteLine();
        if(cases.ContainsKey(ans.Trim().ToLower())){
            cases[ans.Trim().ToLower()]();
        }
        else{
            Console.WriteLine();
            Console.WriteLine("Invalid input! Please try again!");
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
        
    }
        private static Dictionary<string, Action> cases = new(){
        {"browse", browse},
        {"plan", plan},
        {"list", list},
        {"filter", filter},
        {"display", display},
        {"quit", quit}
        
    };
    private static void browse(){
        Browse.browse();
    }
    private static void plan(){
        Plan.plan();
    }
    private static void list(){
        CarVeiwer.listCars();
    }

    private static void filter(){
        Filter.filter();
    }

    private static void display(){
        Console.WriteLine("What is the number of the car you would like to display?");
        int index = Int32.Parse(Console.ReadLine());
        CarVeiwer.veiwWithText(Garage.getCar(index));
    }
    private static void quit(){

    }

     
     
}