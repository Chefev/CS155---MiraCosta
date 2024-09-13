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

namespace Homework3_Part1
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string full_name = NameBox.Text;
            string pig_name = ConvertName(full_name);

            OutputBlock.Text = "Your name in pig latin is " + pig_name;
        }

        public string ConvertName(string name)
        {
            string[] names = name.Split(' ');
            string first = names[0];
            string last = names[1];

            //convert the first name into pig latin
            string first_pig = (Char.ToUpper(first[1]) + first.Substring(2) + Char.ToLower(first[0]) + "ay");
            //convert the last name into pig latin
            string last_pig = (Char.ToUpper(last[1]) + last.Substring(2) + Char.ToLower(last[0]) + "ay");

            //concatenate the two strings into a finalized name
            string pig_latin_name = first_pig + " " + last_pig;
            return pig_latin_name;
        }
    }
}