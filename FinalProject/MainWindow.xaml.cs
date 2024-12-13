using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Chore(object sender, RoutedEventArgs e)
        {
            //error handling
            if (chore_name.Text == "")
            {
                MessageBox.Show("Please enter a chore name");
            }
            else if (days_needed.Text == "")
            {
                MessageBox.Show("Please enter a number of times this chore is needed per week");
            }
            else if (Convert.ToInt16(days_needed.Text) < 0)
            {
                MessageBox.Show("The chore must be needed at least once a week");
            }
            else if (Convert.ToInt16(days_needed.Text) > 7)
            {
                MessageBox.Show("Chores cannot be needed more than 7 days a week");
            }
            else
            {
                Chore chore = new Chore(chore_name.Text, Convert.ToInt16(days_needed.Text));
                FileControl.SaveChore(chore);
            }
        }

        private void Add_Person(object sender, RoutedEventArgs e)
        {
            //error handling
            if (person_name.Text == "")
            {
                MessageBox.Show("Please enter a person name");
            }
            else
            {
                Person person = new Person(person_name.Text, TrueDays());
                FileControl.SavePerson(person);
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            PersonIterator iterator = new PersonIterator();

            List<Chore> chores = FileControl.GetChores();

            //determine the first day that this chore is being done
            foreach (Chore chore in chores)
            {
                Random random = new Random();
                int first_day = random.Next(1, chore.Day_Gap);
                chore.Days.Add(first_day);

                //assign the next person in circulation
                chore.Doers.Add(iterator.GetCurrentPerson(first_day));
                iterator.Increase();

                //setup tracker for how many more times the chore needs to be done
                int chore_counter = (chore.Weekly_Times * 4) - 1;
                int current_day = first_day;

                while (chore_counter != 0)
                {
                    if ((current_day + chore.Day_Gap) > 28)
                    {
                        break;
                    }
                    else
                    {
                        //move forward by the gap days
                        current_day += chore.Day_Gap;
                        //assign the chore to this day
                        chore.Days.Add(current_day);
                        //assign the next person to this chore
                        chore.Doers.Add(iterator.GetCurrentPerson(current_day));
                        iterator.Increase();
                    }

                    chore_counter--;
                }
            }

            //display all the calculated chores
            string output = "";
            for (int i = 1; i <= 28; i++)
            {
                output += $"Day {i}:\n";

                foreach (Chore c in chores)
                {
                    if (c.Days.Contains(i))
                    {
                        //Determine which person is assigned to the chore
                        int person_index = 0;
                        int index_iterator = 0;
                        foreach (int n in c.Days)
                        {
                            if (n == i)
                            {
                                person_index = index_iterator;
                                break;
                            }
                            index_iterator++;
                        }
                        Person doer = c.Doers[person_index];

                        output += $"-{c.Name}: {doer.Name}\n";
                    }
                }

                output += "\n";
            }
            chore_chart.Text = output;
        }

        private void ListView_Selected(object sender, RoutedEventArgs e)
        {
            //get people and chores
            List<Chore> chores = FileControl.GetChores();
            List<Person> people = FileControl.GetPersons();
            
            //generate formatted output strings
            string chores_output = "";
            if (chores.Count == 0)
            {
                chores_output = "There are currently no chores.";
            }
            else
            {
                foreach (Chore c in chores)
                {
                    chores_output += $"{c.Name} to be done {c.Weekly_Times.ToString()} times weekly\n";
                }
            }

            string people_output = "";
            if (people == null || people.Count == 0)
            {
                people_output = "There are currently no people.";
            }
            else
            {
                foreach (Person p in people)
                {
                    people_output += $"{p.Name} is available the following days of the month: {p.ReturnTrueDaysString()}\n";
                }
            }

            chore_view.Text = chores_output;
            people_view.Text = people_output;
        }

        private void ChartView_Selected(object sender, RoutedEventArgs e)
        {
            List<Chore> chores = FileControl.GetChores();
            List<Person> people = FileControl.GetPersons();
            chore_chart.Text = "";
            message.Text = "";
            if (chores.Count == 0 || people.Count == 0)
            {
                message.Text = "Please add chores and people before being able to calculate the chore chart.";
                Calculate.Visibility = Visibility.Hidden;
            }
            else
            {
                Calculate.Visibility = Visibility.Visible;
            }
        }
        public List<int> TrueDays()
        {
            List<int> days = new List<int>();

            if (day_1.IsChecked == true)
            {
                days.Add(1);
            }
            if (day_2.IsChecked == true)
            {
                days.Add(2);
            }
            if (day_3.IsChecked == true)
            {
                days.Add(3);
            }
            if (day_4.IsChecked == true)
            {
                days.Add(4);
            }
            if (day_5.IsChecked == true)
            {
                days.Add(5);
            }
            if (day_6.IsChecked == true)
            {
                days.Add(6);
            }
            if (day_7.IsChecked == true)
            {
                days.Add(7);
            }
            if (day_8.IsChecked == true)
            {
                days.Add(8);
            }
            if (day_9.IsChecked == true)
            {
                days.Add(9);
            }
            if (day_10.IsChecked == true)
            {
                days.Add(10);
            }
            if (day_11.IsChecked == true)
            {
                days.Add(11);
            }
            if (day_12.IsChecked == true)
            {
                days.Add(12);
            }
            if (day_13.IsChecked == true)
            {
                days.Add(13);
            }
            if (day_14.IsChecked == true)
            {
                days.Add(14);
            }
            if (day_15.IsChecked == true)
            {
                days.Add(15);
            }
            if (day_16.IsChecked == true)
            {
                days.Add(16);
            }
            if (day_17.IsChecked == true)
            {
                days.Add(17);
            }
            if (day_18.IsChecked == true)
            {
                days.Add(18);
            }
            if (day_19.IsChecked == true)
            {
                days.Add(19);
            }
            if (day_20.IsChecked == true)
            {
                days.Add(20);
            }
            if (day_21.IsChecked == true)
            {
                days.Add(21);
            }
            if (day_22.IsChecked == true)
            {
                days.Add(22);
            }
            if (day_23.IsChecked == true)
            {
                days.Add(23);
            }
            if (day_24.IsChecked == true)
            {
                days.Add(24);
            }
            if (day_25.IsChecked == true)
            {
                days.Add(25);
            }
            if (day_26.IsChecked == true)
            {
                days.Add(26);
            }
            if (day_27.IsChecked == true)
            {
                days.Add(27);
            }
            if (day_28.IsChecked == true)
            {
                days.Add(28);
            }

            return days;
        }

        private void Clear_Files(object sender, RoutedEventArgs e)
        {
            File.Delete("Chores.txt");
            File.Delete("Persons.txt");
        }
    }
}