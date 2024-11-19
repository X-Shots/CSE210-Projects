using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        shapes.Add(new Square("green", 23));
        shapes.Add(new Rectangle("blue", 2, 5));
        shapes.Add(new Circle("yellow", 23));


        for(int i = 0; i < shapes.Count(); i++){
            Console.WriteLine($"{shapes[i].getColor()} , {shapes[i].getArea()}");
        }
    }
}