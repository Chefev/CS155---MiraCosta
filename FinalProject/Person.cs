using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Person : Datapoint
    {
		public Person(string name, List<int> d)
		{
			this.Name = name;
			this.num_chores = 0;
			this.Days = d;
		}

		private int num_chores;

		public int Num_Chores
		{
			get { return num_chores; }
			set { num_chores = value; }
		}

		public string ReturnTrueDaysString()
		{
            //convert list of ints that represents available days to properly held string
            string days_s = "[";
            List<int> true_days = this.ReturnTrueDays();
            for (int i = 0; i < true_days.Count; i++)
            {
                days_s += true_days[i].ToString();
                if (i + 1 != true_days.Count)
				{
                    days_s += ",";
                }
            }
            days_s += "]";

			return days_s;
        }
	}
}
