using System.Xml.Serialization;

public static class Plan{
    private static int years;
    private static int starting_amount;
    private static int rate;
    private static int ans;
    private static List<Car> cars;
    public static void plan(){
        Console.WriteLine();
        Console.WriteLine("Welcome to the investment Planner!");
        Console.WriteLine("After collecting some basic information, the planner will give you your budget and the option to look at cars within that budget!");
        Console.WriteLine();
        Console.WriteLine("How many years do you plan to invest/save for?");
        years = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What is the amount of your starting deposit?");
        starting_amount = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What is the annual interst rate?(5 for a high-yeild savings account and 10 for index fund investment)");
        rate = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"In {years} years, your savings will grow to {ending_amount()}!");
        Console.WriteLine();
        Console.WriteLine($"Would you like to see which cars you can purchase with {ending_amount()}?(type 'yes' or 'no')");
        if(Console.ReadLine().Trim().ToLower() == "yes"){
            cars = Filter.filterMaxPrice(Garage.getCars(),ending_amount());
            CarVeiwer.listCars(cars);
            do{
                Console.WriteLine();
                Console.WriteLine("Would you like to veiw any of these cars?(type the number of the car you would like to veiw or '0' to quit)");
                ans = Int32.Parse(Console.ReadLine());
                if(ans!=0){
                    CarVeiwer.veiwWithText(Garage.getCar(cars[ans -1].getIndex()));
                }

            }while(ans !=0);
        }
        

    }
    private static double ending_amount(){
        return Math.Round(starting_amount * Math.Pow(1 + (rate / 100.0) , years ),2);
    }

}