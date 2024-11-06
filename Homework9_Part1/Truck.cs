using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    class Truck : Vehicle
    {
		private double load_capacity;

		public double Load_Capacity
		{
			get { return load_capacity; }
			set { load_capacity = value; }
		}

		private int towing_capacity;

		public int Towing_Capacity
		{
			get { return towing_capacity; }
			set { towing_capacity = value; }
		}

		public Truck(Manufacturers brand, int cylinders, Person owner, double load, int towing)
		{
			this.Brand = brand;
			this.Num_Cylinders = cylinders;
			this.Owner = owner;
			this.Load_Capacity = load;
			this.Towing_Capacity = towing;
		}

        public override string ToString()
        {
            return $"This truck is a {this.Brand} with {this.Num_Cylinders} cylinders in the engine, owned by {this.Owner.Name}. It has a load capacity of {this.Load_Capacity} tons and a towing capacity of {this.Towing_Capacity} pounds.";
        }
        public bool Equals(Truck other)
        {
            if (this.Owner == other.Owner && this.Brand == other.Brand && this.Num_Cylinders == other.Num_Cylinders && this.Towing_Capacity == other.Towing_Capacity && this.Load_Capacity == other.Load_Capacity)
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
