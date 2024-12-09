public class SUV : Car{
    private int numSeats;
    private int groundClearence;
    private string driveTrain;

    public SUV(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath, int numSeats, int groundClearence, string driveTrain) : base(startingMSRP, make, model, modelYear, color, specialFeature, imagePath){
        this.numSeats = numSeats;
        this.groundClearence = groundClearence;
        this.driveTrain = driveTrain;
    }

    public override string getType(){
        return "SUV";
    }

    public int getNumSeats(){
        return numSeats;
    }
    public int getGroundClearence(){
        return groundClearence;
    }
    public string getDriveTrain(){
        return driveTrain;
    }
    public override string getHTMLDetails()
    {
        return base.getHTMLDetails() + $"</p> SUV Specifications:</p>~~Number of Seats: {numSeats}</p>~~Ground Clearence: {groundClearence} inches</p>~~Drivetrain: {driveTrain}";
    }

}