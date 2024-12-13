using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PersonIterator
    {
		private int iterator;

		public int Iterator
		{
			get { return iterator; }
			set { iterator = value; }
		}

		private List<Person> people;

		public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}

		private int max_iterator;

		public int Max_Iterator
		{
			get { return max_iterator; }
			set { max_iterator = value; }
		}


		public PersonIterator()
		{
			this.people = FileControl.GetPersons();
			this.iterator = 0;
			this.max_iterator = this.people.Count;
		}

		public void Increase()
		{
			if (this.iterator + 1 >= this.max_iterator)
			{
				this.iterator = 0;
			}
			else
			{
				this.iterator++;
			}
		}

		public Person GetCurrentPerson(int day)
		{
			Person person = this.people[this.Iterator];
			bool check = false;

			while (check == false)
			{
				List<int> true_days = person.ReturnTrueDays();
				if (true_days.Contains(day))
				{
					check = true;
				}
				else
				{
					this.Increase();
				}

				person = this.people[this.Iterator];
			}

			return person;
		}
	}
}
