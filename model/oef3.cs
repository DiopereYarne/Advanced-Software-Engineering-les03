namespace oef3.Models{
     public abstract class Vehicle
    {
        // Properties
        public int Speed { get; set; }
        public string Color { get; set; }

        // Constructor to initialize the Color property
        public Vehicle(string color)
        {
            Color = color;
        }

        // Abstract method that must be implemented by derived classes
        public abstract string DescribeVehicle();
    }

    // Derived class Car
public class Car : Vehicle, IRefuelable
{
    public int NumberOfWheels { get; set; }

    // Constructor that initializes Color and NumberOfWheels
    public Car(string color, int speed, int numberOfWheels) : base(color)
    {
        Speed = speed;
        NumberOfWheels = numberOfWheels;
    }

    // Implement the DescribeVehicle method
    public override string DescribeVehicle()
    {
        return $"Car - Color: {Color}, Speed: {Speed} km/h, Wheels: {NumberOfWheels}";
    }

    // Implement the Refuel method from the IRefuelable interface
    public void Refuel()
    {
        Console.WriteLine("The car is being refueled.");
    }
}

// Derived class Boat
public class Boat : Vehicle
{
    public string TypeOfWater { get; set; }

    // Constructor that initializes Color and TypeOfWater
    public Boat(string color, int speed, string typeOfWater) : base(color)
    {
        Speed = speed;
        TypeOfWater = typeOfWater;
    }

    // Implement the DescribeVehicle method
    public override string DescribeVehicle()
    {
        return $"Boat - Color: {Color}, Speed: {Speed} knots, Type of Water: {TypeOfWater}";
    }
}
// Interface IRefuelable
public interface IRefuelable
{
    void Refuel();
}

}