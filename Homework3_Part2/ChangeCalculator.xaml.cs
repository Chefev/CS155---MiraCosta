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

namespace Homework3_Part2
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
            string price = OptionsBox.Text;
            double price_d = Convert.ToDouble(price.Substring(1));
            Console.WriteLine(price_d);

            int[] change = CalculateChange(price_d);
            Console.WriteLine(change);
            CalculatedChangeBlock.Text = $"You bought an item for {price} and gave me $1.00, so your total change is ${Math.Round(1.0 - price_d, 2)}, which is {change[0]} quarters, {change[1]} dimes, and {change[2]} nickels.";
        }
        public int[] CalculateChange(double price)
        {
            var change = new int[3];
            double change_owed = 1 - price;
            int num_quarters = 0;
            int num_dimes = 0;
            int num_nickels = 0;

           while ((change_owed - 0.25) >= 0)
            {
                num_quarters++;
                change_owed -= 0.25;
            }
            while ((change_owed - 0.1) >= 0)
            {
                num_dimes++;
                change_owed -= 0.1;
            }
            while ((change_owed - 0.05) >= 0)
            {
                num_nickels++;
                change_owed -= 0.05;
            }

            change[0] = num_quarters;
            change[1] = num_dimes;
            change[2] = num_nickels;
            return change;
        }
    }
}