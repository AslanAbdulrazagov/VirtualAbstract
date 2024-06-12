namespace VirtualAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];
            vehicles[0] = new Car("bmw", "g30", 240, "Qara", 2024);
            vehicles[1] = new Bus(50, "qirmizi", 2024);

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}