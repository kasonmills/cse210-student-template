using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var car1 = new Car();
        car1.make = "Honda";
        car1.model = "Civic";
        car1.mileage = 30;
        car1.gallonsOfFuel = 10;

        var miles = car1.RemainingMiles;

        car1.ReduceFuel(3);

        //string carMake1 = "Honda";
        //string carModel1 = "Civic";
        //int carMileage1 = 33;
    }
}

public class Car
{
    public string make;
    public string model;
    public int mileage;
    public int gallonsOfFuel;

    public int RemainingMiles()
    {
        return gallonsOfFuel * mileage;
    }

    public void ReduceFuel(int amount)
    {
        gallonsOfFuel = gallonsOfFuel - amount;
    }
}