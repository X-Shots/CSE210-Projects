using System.Security;

public static class Garage{
    private static List<Car> cars = new();

    public static List<Car> getCars(){
        return cars;
    }
    public static void initialize(){
        string[] lines = System.IO.File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input/cars.txt"));
        foreach(string line in lines){
            string[] carParts = line.Split("~~");
            if(carParts[0] == "coupe"){
                cars.Add(new Coupe(Int32.Parse(carParts[1]), carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],Int32.Parse(carParts[8]),Int32.Parse(carParts[9]),Int32.Parse(carParts[10])));
            }
            else if(carParts[0] == "spyder"){
                cars.Add(new Spyder(Int32.Parse(carParts[1]), carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],Int32.Parse(carParts[8]),Int32.Parse(carParts[9]),Int32.Parse(carParts[10]),carParts[11],carParts[12]));
            }
            else if(carParts[0] == "sedan"){
                cars.Add(new Sedan(Int32.Parse(carParts[1]),carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],Int32.Parse(carParts[8]),Int32.Parse(carParts[9]),Boolean.Parse(carParts[10])));
            }
            else if(carParts[0] == "boat"){
                cars.Add(new Boat(Int32.Parse(carParts[1]),carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],Int32.Parse(carParts[8]),Int32.Parse(carParts[9]),Boolean.Parse(carParts[10]),Int32.Parse(carParts[11]),Int32.Parse(carParts[12]),carParts[13]));
            }
            else if(carParts[0] == "suv"){
                cars.Add(new SUV(Int32.Parse(carParts[1]), carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],Int32.Parse(carParts[8]),Int32.Parse(carParts[9]),carParts[10]));
            }
            else if(carParts[0] == "truck"){
                cars.Add(new Truck(Int32.Parse(carParts[1]), carParts[2],carParts[3],Int32.Parse(carParts[4]),carParts[5],carParts[6],carParts[7],float.Parse(carParts[8]),Int32.Parse(carParts[9])));
            }
        }
    }
    public static Car getCar(int index){
        return cars[index - 1];
    }

    
}