public class Boat : Sedan{
    private int HP;
    private int weight;
    private string boostType;

    public Boat(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath, int MPG, int trunkSpace, bool isHatchback, int HP, int weight, string boostType) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath, MPG, trunkSpace, isHatchback){
        this.HP = HP;
        this.weight = weight;
        this.boostType = boostType;
    }
    public override string getType(){
        return "Boat(Sedan)";
    }

    public int getHP(){
        return HP;
    }
    public int getWeight(){
        return weight;
    }
    public string getBoostType(){
        return boostType;
        
    }

    public override string getHTMLDetails()
    {
        return base.getHTMLDetails() + $"</p>--</p> Boat Specifications:</p>~~Horse Power: {HP}</p>~~Curb Weight: {weight}</p>~~Boost Type: {boostType}";
    }



}