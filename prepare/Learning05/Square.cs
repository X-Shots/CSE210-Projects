public class Square : Shape {
    private double side;

    public Square(string color, double side) : base(color){
        this.side = side;
    }

    public override double getArea(){
        return Math.Pow(side,2);
    }
}