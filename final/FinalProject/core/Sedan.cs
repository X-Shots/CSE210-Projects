public class Sedan : Car {
    private int MPG;
    private int trunkSpace;
    private bool isHatchback;

    public Sedan(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath, int MPG, int trunkSpace, bool isHatchback) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath){
        this.MPG = MPG;
        this.trunkSpace = trunkSpace;
        this.isHatchback = isHatchback;
    }
    public override string getType(){
        return "Sedan";
    }

    public int getMPG(){
        return MPG;
    }
    public int getTrunkSpace(){
        return trunkSpace;
    }
    public bool hasHatchback(){
        return isHatchback;
    }
   public override string getHTMLDetails(){
        return base.getHTMLDetails() + $"</p>--</p>Sedan specifications: </p>~~Miles Per Gallon: {MPG} </p> ~~Trunk Space: {trunkSpace} </p> ~~Has a hatchback: {isHatchback}</p>";
   }

}