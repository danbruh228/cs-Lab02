

Console.WriteLine("\t\t\tShip");
Ship QueenMary2 = new Ship(new int[] {1, 2, 3}, 900000000, 56, 2004, 2620, "Queen Mary Port");
QueenMary2.PrintInfo();

Console.WriteLine("\t\t\tPlane");
Plane Boeing737 = new Plane(new int[] {1, 2, 3}, 112600000, 817, 1988, 11, 103);
Boeing737.PrintInfo();

Console.WriteLine("\t\t\tCar");
Car TeslaModelX = new Car(new int[] {1, 2, 3}, 81630, 250, 2023);
TeslaModelX.PrintInfo();

class Vehicle
{
    private int[] coordinates = new int[3];
    private int price;
    private int speed;
    private int year;
    public Vehicle(int[] coordinates, int price, int speed, int year)
    {
        this.coordinates = coordinates;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Coordinates: {coordinates[0]}, {coordinates[1]}, {coordinates[2]}");
        Console.WriteLine($"Price: {price}$");
        Console.WriteLine($"Max speed: {speed} км/ч");
        Console.WriteLine($"Year: {year}");
    }
}

class Plane : Vehicle
{
    private int altitude;
    private int passengers;

    public Plane(int[] coordinates, int price, int speed, int year, int altitude, int passengers) : base(coordinates,
        price, speed, year)
    {
        
        this.altitude = altitude;
        this.passengers = passengers;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude: {altitude} м");
        Console.WriteLine($"Count of passengers: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(int[] coordinates, int price, int speed, int year) : base(coordinates, price, speed, year) {}
    public override void PrintInfo()
    {
        base.PrintInfo();
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(int[] coordinates, int price, int speed, int year, int passengers, string port) : base(coordinates,
        price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Count of passengers: {passengers}");
        Console.WriteLine($"Port: {port}");
    }
}

*/
