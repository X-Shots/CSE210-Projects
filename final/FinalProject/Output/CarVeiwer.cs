using System;
using System.Diagnostics;
using System.Reflection;


public static class CarVeiwer{
    public static List<Car> cars;
     
    public static void veiwWithText(Car car){
        

        string htmlFilePath = "car_details.html";
        string htmlContent = $@"
        <html>
        <head>
            <title>{car.getMake()} {car.getModel()}</title>
            <style>
                body {{ font-family: Arial, sans-serif; margin: 20px; }}
                img {{ max-width: 100%; height: auto; }}
                .details {{ margin-top: 20px; }}
            </style>
        </head>
        <body>
            <h1>{car.getMake()} {car.getModel()} ({car.getModelYear()} - {car.getType()})</h1>
            <img src='{car.getImagePath()}' alt='Car Image' />
            <div class='details'>
                {car.getHTMLDetails()}
                
            </div>
        </body>
        </html>";

       
        File.WriteAllText(htmlFilePath, htmlContent);

        
        Process.Start("open", htmlFilePath);
        
       
    }
    public static void listCarMakes(){
        List<String> makes = new();
        
        foreach(Car car in Garage.getCars()){
            if(makes.Contains(car.getMake()) != true ){
                makes.Add(car.getMake());
            }
        }
        Console.WriteLine();
        Console.WriteLine("List of all current makes of cars: ");
        foreach(string make in makes){
            Console.WriteLine($"\t{make}");
        }
    }
    public static void listCars(){
        Console.Clear();
        cars = Garage.getCars();
        int count = 1;
        foreach (Car car in cars){
            Console.WriteLine($"{count}. {car.getBasicDetails()}");
            Console.WriteLine();
            count++;
        }

        
    }
    public static void listCars(List<Car> imported_cars){
        int count = 1;
        foreach (Car car in imported_cars){
            Console.WriteLine($"{count}. {car.getBasicDetails()}");
            Console.WriteLine();
            count++;
        }   
    }
}