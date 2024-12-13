using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Chore : Datapoint
    {
        public Chore(string name, int times)
        {
            this.Name = name;
            this.weekly_times = times;
            this.day_gap = (int)Math.Round((7.0 / times));
            this.Doers = new List<Person>();
            this.Days = new List<int>();
        }

        private List<Person> doers;

        public List<Person> Doers
        {
            get { return doers; }
            set { doers = value; }
        }

        private int day_gap;

        public int Day_Gap
        {
            get { return day_gap; }
            set { day_gap = value; }
        }

        private int weekly_times;

        public int Weekly_Times
        {
            get { return weekly_times; }
            set { weekly_times = value; }
        }

    }
}
