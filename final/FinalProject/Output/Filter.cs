using System.IO.Compression;
using System.Net;

public static class Filter{
    private static List<Car> cars;
    
    public static void filter(){
        cars = Garage.getCars();
        string ans = "";
        Console.Clear();
        Console.WriteLine("Welcome to the car Filter!");
        Console.WriteLine("You can filter by:");
        Console.WriteLine("\tMaximum Price(maxp)");
        Console.WriteLine("\tMinimum Price(minp)");
        Console.WriteLine("\tMake(m)");
        Console.WriteLine("\tType(t)");
        Console.WriteLine("Type 'q' to quit");
        Console.WriteLine();
        do{
            ans = Console.ReadLine();
            action(ans);
            Console.WriteLine("\nHere is your updated list of cars!");
            CarVeiwer.listCars(cars);
            Console.WriteLine("\nYou can filter by:");
            Console.WriteLine("\tMaximum Price(maxp)");
            Console.WriteLine("\tMinimum Price(minp)");
            Console.WriteLine("\tMake(m)");
            Console.WriteLine("\tType(t)");
            Console.WriteLine("Type 'q' to quit");
            Console.WriteLine();
        }while(ans != "q");
        

    }
    private static void action(string ans){
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
        {"maxp", maxPrice},
        {"minp", minPrice},
        {"m", make},
        {"t", type},
        {"q", quit}   
    };
    private static void maxPrice(){
        Console.WriteLine("What is the maximum price you would like?");
        cars = filterMaxPrice(cars, Int32.Parse(Console.ReadLine()));
    }
    private static void minPrice(){
        Console.WriteLine("What is the minimum price you would like?");
        cars = filterMinPrice(cars, Int32.Parse(Console.ReadLine()));
    }
    private static void make(){
        Console.WriteLine();
        CarVeiwer.listCarMakes();
        Console.WriteLine("\nWhich make would you like to look at?");
        cars = filterMake(cars, Console.ReadLine());
    }
    private static void type(){
        Console.WriteLine();
        Console.WriteLine("Here are the types of cars you can chose from:");
        Console.Write("\n\tCoupe\n\tSedan\n\tSUV\n\tTruck");
        Console.WriteLine();
        Console.WriteLine("What type would you like to look at?");
        cars = filterType(cars, Console.ReadLine());
    }

    

    public static List<Car> filterMaxPrice(List<Car> imported_cars, double price){
        List<Car> temp_cars = new();
        foreach(Car car in imported_cars){
            if(car.getStartingMsrp() <= price){
                temp_cars.Add(car);
            }
        }
        return temp_cars;


    }

    public static List<Car> filterMinPrice(List<Car> imported_cars, double price){
        List<Car> temp_cars = new();
        foreach(Car car in imported_cars){
            if(car.getStartingMsrp() >= price){
                temp_cars.Add(car);
            }
        }
        return temp_cars;


    }
    public static List<Car> filterMake(List<Car> imported_cars, string make){
        List<Car> temp_cars = new();
        foreach(Car car in imported_cars){
            if(car.getMake().Trim().ToLower() == make.Trim().ToLower()){
                temp_cars.Add(car);
            }
        }
        return temp_cars;
    }
    public static List<Car> filterType(List<Car> imported_cars, string type){
        List<Car> temp_cars = new();
        foreach(Car car in imported_cars){
            if(car.getType().Trim().ToLower() == type.Trim().ToLower()){
                temp_cars.Add(car);
            }
        }
        return temp_cars;
    }
    private static void quit(){

    }

    
   
    

    
}