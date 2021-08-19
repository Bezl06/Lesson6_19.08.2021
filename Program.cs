using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car merc = new Car(270, "Black", "Mercedes");
            merc.speed = 100;
            System.Console.WriteLine(merc);
            merc.speed = 100000;
            System.Console.WriteLine(merc);
        }
    }
    class Car
    {
        public int maxSpeed { get; }
        public string color { get; }
        public string name { get; }
        private int _speed;
        public int speed
        {
            get => _speed;
            set { _speed = value > maxSpeed ? value < 0 ? 0 : value : maxSpeed; }
        }
        public Car(int maxSpeed, string color, string name)
        {
            this.maxSpeed = maxSpeed;
            this.color = color;
            this.name = name;
        }
        public override string ToString() => $"Name : {name} , Color : {color}\nSpeed : {speed} , MaxSpeed : {maxSpeed} ";
    }
}
