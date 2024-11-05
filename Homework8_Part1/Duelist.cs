using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Part1
{
    public class Duelist
    {
		public Duelist(string n, double a)
		{
			name = n;
			accuracy = a;
			alive = true;
		}
		
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double accuracy;

		public double Accuracy
		{
			get { return accuracy; }
			set { accuracy = value; }
		}

		private bool alive;

		public bool Alive
		{
			get { return alive; }
			set { alive = value; }
		}

		public void ShootAtTarget(Duelist target)
		{
			double chance = this.Accuracy * 1000;
			Random random = new Random();
			int rand_num = random.Next(0, 1000);

			if (rand_num <= chance)
			{
				target.Alive = false;
			}
		}

	}
}
