using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalProject
{
    class FileControl
    {
        //methods for chore file
        public static void CreateChoreFile()
        {
            StreamWriter writer = new StreamWriter("Chores.txt");
            writer.Close();
        }

        public static List<Chore> GetChores()
        {
            if (!File.Exists("Chores.txt"))
            {
                CreateChoreFile();
            }

            StreamReader reader = new StreamReader("Chores.txt");
            List<Chore> chores = new List<Chore>();

            try
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');

                    Chore c = new Chore(data[0], Convert.ToInt16(data[1]));
                    chores.Add(c);
                }

                if (reader.Peek() != -1)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            reader.Close();
            return chores;
        }

        public static void SaveChore(Chore c)
        {
            if (!File.Exists("Chores.txt"))
            {
                CreateChoreFile();
            }

            StreamWriter writer = new StreamWriter("Chores.txt", true);
            writer.WriteLine($"{c.Name},{c.Weekly_Times.ToString()}");
            writer.Close(); 
        }

        //methods for persons file
        public static void CreatePersonsFile()
        {
            StreamWriter writer = new StreamWriter("Persons.txt");
            writer.Close();
        }

        public static List<Person> GetPersons()
        {
            if (!File.Exists("Persons.txt"))
            {
                CreatePersonsFile();
            }

            StreamReader reader = new StreamReader("Persons.txt");
            List<Person> people = new List<Person>();

            try
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(':');

                    //convert string days to a list of ints
                    List<int> days = new List<int>();
                    char[] trimming_chars = ['[', ']'];
                    string[] file_days = data[1].Trim(trimming_chars).Split(',');
                    for (int i = 0; i < file_days.Length; i++)
                    {
                        days.Add(Convert.ToInt16(file_days[i]));
                    }

                    Person p = new Person(data[0], days);
                    people.Add(p);
                }

                if (reader.Peek() != -1)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            reader.Close();
            return people;
        }

        public static void SavePerson(Person p)
        {
            if (!File.Exists("Persons.txt"))
            {
                CreatePersonsFile();
            }

            string days = p.ReturnTrueDaysString();

            StreamWriter writer = new StreamWriter("Persons.txt", true);
            writer.WriteLine($"{p.Name}:{days}");
            writer.Close();
        }
    }
}
