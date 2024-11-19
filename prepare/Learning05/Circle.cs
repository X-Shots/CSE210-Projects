public class Circle : Shape{
    private double rad;

    public Circle(string color, int rad) : base(color){
        this.rad = rad;
    }

    public override double getArea(){
        return Math.PI * Math.Pow(rad,2);
    }
}