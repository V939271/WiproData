using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void GetInfo() { }
}

class Car : Vehicle
{
    public Car(string make, string model, int year) : base(make, model, year) { }

    public override void GetInfo()
    {
        Console.WriteLine($"Car: {Year} {Make} {Model}");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year) : base(make, model, year) { }

    public override void GetInfo()
    {
        Console.WriteLine($"Motorcycle: {Year} {Make} {Model}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Car input
        Console.WriteLine("Enter car make:");
        string carMake = Console.ReadLine();

        Console.WriteLine("Enter car model:");
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter car year:");
        int carYear = Convert.ToInt32(Console.ReadLine());

        // Motorcycle input
        Console.WriteLine("Enter motorcycle make:");
        string motoMake = Console.ReadLine();

        Console.WriteLine("Enter motorcycle model:");
        string motoModel = Console.ReadLine();

        Console.WriteLine("Enter motorcycle year:");
        int motoYear = Convert.ToInt32(Console.ReadLine());

        // Object creation
        Car car = new Car(carMake, carModel, carYear);
        Motorcycle motorcycle = new Motorcycle(motoMake, motoModel, motoYear);

        // Output (must match expected exactly)
        car.GetInfo();
        motorcycle.GetInfo();
    }
}