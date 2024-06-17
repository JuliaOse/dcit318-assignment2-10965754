// See https://aka.ms/new-console-template for more information
using System;

abstract class Shape{
    public abstract double GetArea();
}

class Circle: Shape{
    private int radius;

    public Circle(int radius){
        this.radius = radius;
    }
    public override double GetArea()
    {
        return 3.14*radius*radius;
    }
}

class Rectangle: Shape{
    private int l;
    private int b;

    public Rectangle(int l, int b){
        this.l = l;
        this.b =b;
    }

    public override double GetArea()
    {
        return l*b;
    }
}
class Program{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5); 

        double area = circle.GetArea(); 
        Console.WriteLine($"Area of the circle: {area} square units");

        Rectangle rect = new Rectangle(5,8); 

        double Rectarea = rect.GetArea(); 
        Console.WriteLine($"Area of the rectangle: {Rectarea} square units");
    }
}
