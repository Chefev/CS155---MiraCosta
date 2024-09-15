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

namespace Homework3_Lab1
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
            double balance = Convert.ToDouble(BalanceBlock.Text);
            double payment = Convert.ToDouble(PaymentBox.Text);
            const double annual_interest = 6.39;
            const double monthly_interest = annual_interest / 12;

            double monthly_interest_payment = Math.Round(balance * (monthly_interest/100), 2);
            double balance_payment = Math.Round(payment - monthly_interest_payment, 2);

            OutputBlock.Text = $"${monthly_interest_payment} of your monthly payment goes towards the interest, while ${balance_payment} goes towards lowering the principle amount.";
        }
    }
}