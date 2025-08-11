namespace exampleMethodOverriding;
using System;

public class Circle
{
    double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public virtual void Area()
    {
        Console.WriteLine("Calculating area of Circle");
    }
}
public class Cylinder : Circle
{
    double height;

    public Cylinder(double r, double h) : base(r)
    {
        height = h;
    }
    public override void Area()
    {
        Console.WriteLine("Calculating area of Cylinder");
    }
}
public class Cone : Circle
{
    public Cone(double r) : base(r)
    {

    }
    public override void Area()
    {
        Console.WriteLine("Calculating area of Cone");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Cylinder(5, 10);
        Circle cone = new Cone(5);
        PrintArea(10,2);
    }
    static void PrintArea(int a)
    {
        Console.WriteLine("Calculating area of Circle with radius: " + a);
    }
    static void PrintArea(double a,double b)
    {
        Console.WriteLine("Calculating area of Circle with radius: " + a + " and height: " + b);
    }
}

