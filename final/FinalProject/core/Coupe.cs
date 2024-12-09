public class Coupe : Car {
    private int headRoom;
    private int topSpeed;
    private int numProduced;
    public Coupe(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath, int headRoom, int topSpeed, int numProduced) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath){
        this.headRoom = headRoom;
        this.topSpeed = topSpeed;
        this.numProduced = numProduced;
    }
    public override string getType(){
        return "SuperCar";
    }
    public override string getHTMLDetails()
    {
        return base.getHTMLDetails() + $"</p>Coupe Specifications:</p>~~Head Room: {headRoom} inches</p>~~Top Speed: {topSpeed} MPH</p>~~Number Produced: {numProduced}";
    }

    public int getHeadRoom(){
        return headRoom;
    }
    public int getTopSpeed(){
        return topSpeed;
    }
    public int getNumProduced(){
        return numProduced;
    }
}