using System;
using System.Windows.Forms;

namespace lab1
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public double DailyMaintenanceCost { get; set; }

        public Animal(string name, double weight, int age, double dailyMaintenanceCost)
        {
            Name = name;
            Weight = weight;
            Age = age;
            DailyMaintenanceCost = dailyMaintenanceCost;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Weight: {Weight} kg, Age: {Age} years, Daily Maintenance Cost: ${DailyMaintenanceCost}";
        }
    }

    public class Wolf : Animal
    {
        public string Breed { get; set; }
        public string NaturalLocation { get; set; }

        public Wolf(string name, double weight, int age, double dailyMaintenanceCost, string breed, string naturalLocation)
            : base(name, weight, age, dailyMaintenanceCost)
        {
            Breed = breed;
            NaturalLocation = naturalLocation;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Breed: {Breed}, Natural Location: {NaturalLocation}";
        }
    }
}
