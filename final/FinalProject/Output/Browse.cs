using System.ComponentModel;

public static class Browse{
    public static List<Car> cars;
    public static void browse(){
        cars = Garage.getCars();
        Random rand = new Random();
        Console.Clear();
        Console.WriteLine("Welsome to the browsing section!");
        Console.WriteLine("Press 'Enter' to display the details of a random car!(Type anything else to go back.)");
        string ans = Console.ReadLine();
        while(ans == ""){
            Console.Clear();
            if(cars.Count() > 0){
                int car_index = rand.Next(1,cars.Count());
                CarVeiwer.veiwWithText(Garage.getCar(car_index));
                cars.RemoveAt(car_index - 1);
                Console.WriteLine("Press 'Enter' to display the details of another random car!(Type anything else to go back.)");
                ans = Console.ReadLine();
            }
            else{
                Console.WriteLine("You have vewied all of the cars!");
                Console.WriteLine("Press any key to go back!");
                ans = Console.ReadLine();
                ans = "quit";
            }
            
            
        }
        
        

    }
}
