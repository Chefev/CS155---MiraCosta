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

namespace Homework4_Part1
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
            int weight = Convert.ToInt32(Weight.Text);
            int height = Convert.ToInt32(Height.Text);

            double bmi_double = (weight * 720) / (height * height);

            double bmi = Math.Round(bmi_double);

            BMI.Text = $"Your BMI is {bmi}";

            if (bmi > 26)
            {
                ColorBox.Fill = System.Windows.Media.Brushes.Yellow;
            } else if (bmi < 15)
            {
                ColorBox.Fill = System.Windows.Media.Brushes.DarkBlue;
            } else
            {
               ColorBox.Fill = System.Windows.Media.Brushes.Green;
            }
        }
    }
}