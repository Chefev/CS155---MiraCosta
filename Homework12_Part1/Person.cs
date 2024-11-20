using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_Part1
{
    class Person
    {
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		public Person(int age, string name, double height)
		{
			this.age = age;
			this.name = name;
			this.height = height;
		}
	}
}
