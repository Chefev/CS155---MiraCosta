using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_Part1
{
    class Rank
    {
		private string count;

		public string Count
		{
			get { return count; }
			set { count = value; }
		}

		private int ranking;

		public int Ranking
		{
			get { return ranking; }
			set { ranking = value; }
		}

		public Rank(string count, int rank)
		{
			this.Count = count;
			this.Ranking = rank;
		}
	}
}
