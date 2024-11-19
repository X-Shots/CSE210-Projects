using System.Drawing;

public class Rectangle : Shape{
    private double width;
    private double length;

    public Rectangle(string color, int width, int length) : base(color){
        this.width = width;
        this.length = length;
    }

    public override double getArea(){
        return width * length;
    }
}