using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Lab1
{
    class Phonebook
    {
		private Dictionary<string, long> book;

        public Phonebook()
		{
			book = new Dictionary<string, long>();
		}

		public void AddNumber(string name, long number)
		{
			book.Add(name, number);
		}

		public void RemoveNumber(string name)
		{
			book.Remove(name);
		}

		public long FindNumber(string name)
		{
			if (book.ContainsKey(name) == true)
			{
				return book[name];
			}
			else
			{
				return 0;
			}
		}

		public void Print()
		{
			foreach (KeyValuePair<string, long> pair in book)
			{
				Console.WriteLine($"{pair.Key} - {pair.Value}");
			}
		}
	}
}
