using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Datapoint
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        private List<int> days;

        public List<int> Days
        {
            get { return days; }
            set { days = value; }
        }

        //returns indices of days that are activated, whether a chore or a person
        public List<int> ReturnTrueDays()
        {
            List<int> true_days = new List<int>();

            //loop through all days in this object
            for (int i = 0; i < this.days.Count; i++)
            {
                true_days.Add(days[i]);
            }

            return true_days;
        }
    }
}
