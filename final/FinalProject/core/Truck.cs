public class Truck : Car{
    private float bedLength;
    private int towingCapacity;
    public Truck(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath,int index, float bedLength, int towingCapacity) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath,index){
        this.bedLength = bedLength;
        this.towingCapacity = towingCapacity;
    }
    public override string getType(){
        return "Truck";
    }
    public override string getHTMLDetails()
    {
        return base.getHTMLDetails() + $"</p>Truck Specifications:</p>~~Bed Length: {bedLength} feet</p>~~Towing Capacity: {towingCapacity}lbs";
    }
    public float getBedLength(){
        return bedLength;
    }
    public int getTowingCapacity(){
        return towingCapacity;
    }
    public override string getBasicDetails()
    {
        return base.getBasicDetails() + $"\nCar Type: Truck";
    }
}