using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstract
{
    class Car : Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public int MaxSpeed { get; }

        public Car(string brand, string model, int maxSpeed, string color, int year) : base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car Info:\nBrand: {Brand}\nModel: {Model}\nMax Speed: {MaxSpeed} km/h\nColor: {Color}\nYear: {Year}");
        }
    }
}
