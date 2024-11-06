using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    internal class Vehicle
    {
        public enum Manufacturers
        {
            Toyota,
            Honda,
            Ram,
            Ford,
            Hyundai,
            Lexus,
            BMW,
            Tesla
        }

        private Manufacturers brand;

        public Manufacturers Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private int num_cylinders;

        public int Num_Cylinders
        {
            get { return num_cylinders; }
            set { num_cylinders = value; }
        }

        private Person owner;

        public Person Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Vehicle()
        {
            this.Brand = Manufacturers.Toyota;
            this.Num_Cylinders = 4;
            this.Owner = new Person();
        }

        public Vehicle(Manufacturers brand)
        {
            this.Brand = brand;
            this.Num_Cylinders = 4;
            this.Owner = new Person();
        }

        public Vehicle(Manufacturers brand, int cylinders)
        {
            this.Brand = brand;
            this.Num_Cylinders = cylinders;
            this.Owner = new Person();
        }

        public Vehicle(Manufacturers brand, int cylinders, Person owner)
        {
            this.Brand = brand;
            this.Num_Cylinders = cylinders;
            this.Owner = owner;
        }

        public override string ToString()
        {
            return $"This vehicle is a {this.Brand} with {this.Num_Cylinders} cylinders in the engine, owned by {this.Owner.Name}";
        }

        public bool Equals(Vehicle other)
        {
            if (this.Owner == other.Owner && this.Brand == other.Brand && this.Num_Cylinders == other.Num_Cylinders)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
