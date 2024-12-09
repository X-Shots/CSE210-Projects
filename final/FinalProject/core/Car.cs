public abstract class Car{
    private int startingMSRP;
    private string make;
    private string model;
    private int modelYear;
    private string color;
    
    private string specialFeature;
    private string imagePath;

    public Car(int startingMSRP, string make, string model, int modelYear, string color, string specialFeature, string imagePath){
        this.startingMSRP = startingMSRP;
        this.make = make;
        this.model = model;
        this.modelYear = modelYear;
        this.color = color;
        
        this.specialFeature = specialFeature;
        this.imagePath = imagePath;
    }
    public abstract string getType();
    public virtual string getHTMLDetails(){
                return $"<p><Strong>Basic specifications:<strong>\n<p> ~~Price:</strong>   ${startingMSRP:N0}</p>    ~~Make: {make}<p>~~Model: {model}</p>~~Model Year: {modelYear}</p>~~Color: {color}</p>~~Special Feature: {specialFeature}</p>";

    }

    public int getStartingMsrp(){
        return startingMSRP;
    }
    public string getMake(){
        return make;
    }
    public string getModel(){
        return model;
    }
    public string getColor(){
        return color;
    }
    public string getImagePath(){
        return imagePath;
    }
    public int getModelYear(){
        return modelYear;
    }


    
}