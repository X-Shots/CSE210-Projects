public class Spyder : Coupe{
    private string topType;
    private string engineLayout;
    public Spyder(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath,int index, int headRoom, int topSpeed, int numProduced, string topType, string engineLayout ) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath, headRoom, topSpeed, numProduced,index){
        this.topType = topType;
        this.engineLayout = engineLayout;
    }
    public override string getType(){
        return "Spyder(SuperCar)";
    }
    public override string getHTMLDetails()
    {
        return base.getHTMLDetails() + $"</p>Spyder Specifications:</p>~~Convertible Type: {topType}</p>~~Engine Layout: {engineLayout}";
    }
    public string getTopType(){
        return topType;
    }
    public string getEngineLayout(){
        return engineLayout;
    }
    public override string getBasicDetails()
    {
        return base.getBasicDetails() + "~~Spyder";
    }

}