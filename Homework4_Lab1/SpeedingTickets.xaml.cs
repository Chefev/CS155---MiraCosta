using System.Media;
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

namespace Homework4_Lab1
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
            int speed = Convert.ToInt32(Speed.Text);
            int limit = Convert.ToInt32(SpeedLimit.Text);
            int price = 0;

            if (speed > limit)
            {
                price += 60;

                for (int i = speed; i > limit; i--)
                {
                    price += 7;
                }

                ColorBox.Fill = System.Windows.Media.Brushes.Yellow;
            }

            if (speed > (limit + 25)) {
                price += 250;

                ColorBox.Fill = System.Windows.Media.Brushes.OrangeRed;
            }

            if (speed <= limit) {
                price = 0;

                ColorBox.Fill = System.Windows.Media.Brushes.Green;
            }

            TicketPrice.Text = $"Ticket Price: ${price}";
        }
    }
}