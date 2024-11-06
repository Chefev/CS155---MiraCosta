using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1
{
    class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public override string ToString()
        {
            return $"This person's name is {this.name}";
        }

        public bool Equals(Person other)
        {
            if (other == this)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Person()
        {
            this.Name = "Bob";
        }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}
