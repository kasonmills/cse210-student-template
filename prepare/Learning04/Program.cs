using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

    }


}

public class Vehicle
{
    protected string _make;
    protected string _model;
    protected int _miles;

    public Vehicle(string _make, string _model, int _miles)
    {
        _make = _make;
        _model = model;
        _miles = miles;       
    }
}

public class Car: Vehicle
{
    public Car(string make, string model, int miles) :base(make, model, miles)
    {

    }
}

public class Truck:Vehicle
{
    private int _towing;

    public Truck(string make, string model, int miles) :base(make, model, miles)
    {

    }
}

public class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
}

public class Circle: Shape
{
    private float _radius;
    public Circle(string color, float radius) :base(color)
    {
        _radius = radius;
    }

    public float Area()
    {

    }
}

public class Square: Shape
{
    private float _sideLength;
    public Square(string color, float sideLength) :base(color)
    {
        _sideLength = sideLength;
    }

    public float Area()
    {
        
    }
}