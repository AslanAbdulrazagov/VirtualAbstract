namespace VirtualAbstract;

class Bus : Vehicle
{
    public int PassengerCount { get; }

    public Bus(int passengerCount, string color, int year) : base(year)
    {
        PassengerCount = passengerCount;
        Color = color;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Passenger Count: {PassengerCount} Color: {Color} Year: {Year}");
    }
}
