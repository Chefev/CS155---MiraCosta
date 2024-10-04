/// Homework No.6 Lab 1
/// File Name: Calculator.xaml.cs
/// @author: Parker Verran
/// Date: Oct. 4th, 2024
///
/// Problem Statement: Create a simple GUI calculator with error handling built in
///
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Read the values from the inputs and the math operator
/// 2. Convert these values to integers rather than strings
/// 3. Try to calculate the requested math problem
/// 4. Catch any errors and display a corresponding error message to the user
/// 5. If there are no errors then display the results of the calculation to the user
///

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

namespace Homework6_Lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                double left_value = Convert.ToDouble(LeftValue.Text);
                double right_value = Convert.ToDouble(RightValue.Text);
                string operator_choice = OptionsBox.Text;
                double result = 0;

                switch (operator_choice)
                {
                    case "+":
                        result = left_value + right_value;
                        break;
                    case "-":
                        result = left_value - right_value;
                        break;
                    case "*":
                        result = left_value * right_value;
                        break;
                    case "/":
                        result = left_value / right_value;
                        break;
                    case "%":
                        result = left_value % right_value;
                        break;
                }
                Results.Text = result.ToString();
            } catch (Exception error)
            {
                MessageBox.Show($"Invalid input, resulted in error message: {error}");
            }
        }
    }
}